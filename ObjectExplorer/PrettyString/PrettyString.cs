namespace ObjectExplorer.PrettyString;

using Extensions;
using Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>
///     Provides static methods to convert any object into a readable string.
/// </summary>
public static class PrettyString {
    private static readonly ExceptionConverter<Exception> ExceptionConverter = new();
    private static readonly JsonSerializerOptions JsonOpts;

    static PrettyString() {
        JsonOpts = new JsonSerializerOptions();
        JsonOpts.Converters.Add(ExceptionConverter);
    }

    /// <summary>
    ///     Converts an object to a serialized JSON string that supports exceptions.
    /// </summary>
    /// <param name="argument">The object to convert.</param>
    /// <returns>A <see cref="string" /> representation of <paramref name="argument" />.</returns>
    public static string Jsonify(object? argument) {
        return JsonSerializer.Serialize(argument, JsonOpts);
    }

    /// <summary>
    ///     Converts an object to a readable string.
    /// </summary>
    /// <param name="argument">The object to convert.</param>
    /// <param name="indentationStyle">Optional indentation style options.</param>
    /// <returns>A <see cref="string" /> representation of <paramref name="argument" />.</returns>
    public static string Stringify(object? argument,
                                   IndentationStyle indentationStyle = IndentationStyle.NoIndentation,
                                   int maxDepth = 64) {
        var referenceStack = new Stack<object>();
        var stringBuilder = new StringBuilder();

        Stringify(argument, indentationStyle, 0, stringBuilder, referenceStack, maxDepth);
        return stringBuilder.ToString();
    }

    private static void Stringify(object? argument,
                                  IndentationStyle indentationStyle,
                                  int indentationLevel,
                                  StringBuilder stringBuilder,
                                  Stack<object> referenceStack,
                                  int maxDepth) {
        if(indentationLevel > maxDepth) {
            stringBuilder.Append($"max depth of {maxDepth} reached");
            return;
        }

        switch(argument) {
            case null:
                stringBuilder.Append("null");
                return;
            case string s:
                stringBuilder.Append(s);
                return;
        }

        var type = argument.GetType();

        if(type.IsValueType) {
            if(type.IsPrimitive) {
                stringBuilder.Append(argument);
                return;
            }

            if(type.IsEnum) {
                stringBuilder.Append(argument);
                return;
            }

            if(type == typeof(DateTime)) {
                stringBuilder.Append(argument);
                return;
            }

            StringifyObject(argument, indentationStyle, indentationLevel, stringBuilder, referenceStack, maxDepth);
            return;
        }

        if(type.ImplementsIDictionary) {
            StringifyDictionary(argument, indentationStyle, indentationLevel, stringBuilder, referenceStack, maxDepth);
            return;
        }

        if(type.ImplementsIEnumerable) {
            StringifyEnumerable(argument, indentationStyle, indentationLevel, stringBuilder, referenceStack, maxDepth);
            return;
        }

        StringifyObject(argument, indentationStyle, indentationLevel, stringBuilder, referenceStack, maxDepth);
    }

    private static void StringifyDictionary(object argument,
                                            IndentationStyle indentationStyle,
                                            int indentationLevel,
                                            StringBuilder stringBuilder, Stack<object> referenceStack,
                                            int maxDepth) {
        //Ensure argument isn't in the reference stack
        if(referenceStack.Any(r => ReferenceEquals(r, argument))) {
            stringBuilder.Append(argument.GetType().Name);
            stringBuilder.Append(" (skipped)");
            return;
        }

        var dictionary = TypeUtils.CastDict((IDictionary)argument).ToDictionary(entry => entry.Key, entry => entry.Value);

        if(dictionary.Count == 0) {
            stringBuilder.Append("{ }");
            return;
        }

        referenceStack.Push(argument);

        var isAtStartOfLine = false;
        var hadAnyLineBreaks = false;

        stringBuilder.Append('{');

        foreach(var kvp in dictionary) {
            if(indentationStyle == IndentationStyle.IndentNestedValues ||
               (indentationStyle == IndentationStyle.IndentNestedObjects && TypeUtils.ShouldBeIndented(kvp.Value))) {
                stringBuilder.Append('\n');
                stringBuilder.Append(new string(' ', (indentationLevel + 1) * 4));

                isAtStartOfLine = true;
                hadAnyLineBreaks = true;
            }

            if(!isAtStartOfLine) {
                stringBuilder.Append(' ');
            }

            stringBuilder.Append("[ ");
            stringBuilder.Append(kvp.Key);
            stringBuilder.Append(" ] = ");
            Stringify(kvp.Value, indentationStyle, indentationLevel + 1, stringBuilder, referenceStack, maxDepth);
            stringBuilder.Append(',');

            isAtStartOfLine = false;
        }

        stringBuilder.Length--;

        if(!hadAnyLineBreaks) {
            stringBuilder.Append(" }");
        } else {
            stringBuilder.Append('\n');
            stringBuilder.Append(new string(' ', indentationLevel * 4));
            stringBuilder.Append('}');
        }

        //Remove argument and subsequent items from reference stack
        object stackItem;

        do {
            stackItem = referenceStack.Pop();
        } while(!ReferenceEquals(argument, stackItem));
    }

    private static void StringifyEnumerable(object argument,
                                            IndentationStyle indentationStyle,
                                            int indentationLevel,
                                            StringBuilder stringBuilder,
                                            Stack<object> referenceStack,
                                            int maxDepth) {
        //Ensure argument isn't in the reference stack
        if(referenceStack.Any(r => ReferenceEquals(r, argument))) {
            stringBuilder.Append(argument.GetType().Name);
            stringBuilder.Append(" (skipped)");
            return;
        }

        referenceStack.Push(argument);

        var enumerable = TypeUtils.CastEnumerable((IEnumerable)argument);

        var isAtStartOfLine = false;
        var hadAnyLineBreaks = false;
        var wasEmpty = true;

        stringBuilder.Append('[');

        foreach(var element in enumerable) {
            if(indentationStyle == IndentationStyle.IndentNestedValues ||
               (indentationStyle == IndentationStyle.IndentNestedObjects && TypeUtils.ShouldBeIndented(element))) {
                stringBuilder.Append('\n');
                stringBuilder.Append(new string(' ', (indentationLevel + 1) * 4));

                isAtStartOfLine = true;
                hadAnyLineBreaks = true;
            }

            if(!isAtStartOfLine) {
                stringBuilder.Append(' ');
            }
            
            Stringify(element, indentationStyle, indentationLevel + 1, stringBuilder, referenceStack, maxDepth);
            stringBuilder.Append(',');

            wasEmpty = false;
            isAtStartOfLine = false;
        }

        if(!wasEmpty) {
            stringBuilder.Length--;
        }

        if(!hadAnyLineBreaks) {
            stringBuilder.Append(" ]");
        } else {
            stringBuilder.Append('\n');
            stringBuilder.Append(new string(' ', indentationLevel * 4));
            stringBuilder.Append(']');
        }
        
        //Remove argument and subsequent items from reference stack
        object stackItem;

        do {
            stackItem = referenceStack.Pop();
        } while(!ReferenceEquals(argument, stackItem));
    }

    private static void StringifyObject(object argument,
                                        IndentationStyle indentationStyle,
                                        int indentationLevel,
                                        StringBuilder stringBuilder,
                                        Stack<object> referenceStack,
                                        int maxDepth) {
        var type = argument.GetType();

        //Ensure argument isn't in the reference stack
        if(!type.IsValueType && referenceStack.Any(r => ReferenceEquals(r, argument))) {
            stringBuilder.Append(type.Name);
            stringBuilder.Append(" (skipped)");
            return;
        }

        if(type.Name is "RuntimeType" or "Type") {
            stringBuilder.Append("Type (");
            stringBuilder.Append(type.Name);
            stringBuilder.Append(')');
            return;
        }

        stringBuilder.Append(type.Name);

        var propList = TypeUtils.GetProperties(argument, type);

        if(propList.Length == 0) {
            return;
        }

        if(!type.IsValueType) {
            referenceStack.Push(argument);
        }

        var isAtStartOfLine = false;
        var hadAnyLineBreaks = false;

        stringBuilder.Append(" {");

        foreach(var prop in propList) {
            if(indentationStyle == IndentationStyle.IndentNestedValues ||
               (indentationStyle == IndentationStyle.IndentNestedObjects && TypeUtils.ShouldBeIndented(prop.property))) {
                stringBuilder.Append('\n');
                stringBuilder.Append(new string(' ', (indentationLevel + 1) * 4));

                isAtStartOfLine = true;
                hadAnyLineBreaks = true;
            }

            if(!isAtStartOfLine) {
                stringBuilder.Append(' ');
            }

            stringBuilder.Append(prop.name);
            stringBuilder.Append(" = ");
            Stringify(prop.property, indentationStyle, indentationLevel + 1, stringBuilder, referenceStack, maxDepth);
            stringBuilder.Append(',');
            
            isAtStartOfLine = false;
        }

        stringBuilder.Length--;

        if(!hadAnyLineBreaks) {
            stringBuilder.Append(" }");
        } else {
            stringBuilder.Append('\n');
            stringBuilder.Append(new string(' ', indentationLevel * 4));
            stringBuilder.Append('}');
        }
        
        //Remove argument and subsequent items from reference stack
        if(!type.IsValueType) {
            object stackItem;

            do {
                stackItem = referenceStack.Pop();
            } while(!ReferenceEquals(argument, stackItem));
        }
    }
}