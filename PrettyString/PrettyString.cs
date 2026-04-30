// <copyright file="PrettyString.cs" company="Air Line Pilots Association">
// Copyright (c) Air Line Pilots Association. All rights reserved.
// </copyright>

namespace ObjectExplorer.PrettyString;

using System.Collections;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Extensions;
using Json;

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
                                   IndentationStyle indentationStyle = IndentationStyle.NoIndentation) {
        var stringBuilder = new StringBuilder();
        Stringify(argument, indentationStyle, 0, stringBuilder);
        return stringBuilder.ToString();
    }

    private static IEnumerable<DictionaryEntry> CastDict(IDictionary dictionary) {
        foreach(DictionaryEntry entry in dictionary) {
            yield return entry;
        }
    }

    private static IEnumerable<object> CastEnumerable(IEnumerable enumerable) {
        foreach(var entry in enumerable) {
            yield return entry;
        }
    }

    private static bool ShouldBeIndented(object? argument) {
        if(argument is null or string) {
            return false;
        }

        return !argument.GetType().IsValueType;
    }

    private static void Stringify(object? argument,
                                  IndentationStyle indentationStyle,
                                  int indentationLevel,
                                  StringBuilder stringBuilder) {
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
            stringBuilder.Append(argument.ToString() ?? string.Empty);
            return;
        }

        if(type.ImplementsIDictionary) {
            StringifyDictionary(argument, indentationStyle, indentationLevel, stringBuilder);
            return;
        }

        if(type.ImplementsIEnumerable) {
            StringifyEnumerable(argument, indentationStyle, indentationLevel, stringBuilder);
            return;
        }

        StringifyObject(argument, indentationStyle, indentationLevel, stringBuilder);
    }

    private static void StringifyDictionary(object argument,
                                            IndentationStyle indentationStyle,
                                            int indentationLevel,
                                            StringBuilder stringBuilder) {
        var dictionary = CastDict((IDictionary)argument).ToDictionary(entry => entry.Key, entry => entry.Value);

        if(dictionary.Count == 0) {
            stringBuilder.Append("{ }");
            return;
        }

        var hadLineBreak = false;

        stringBuilder.Append("{ ");

        foreach(var kvp in dictionary) {
            if(indentationStyle == IndentationStyle.IndentNestedValues ||
               (indentationStyle == IndentationStyle.IndentNestedObjects && ShouldBeIndented(kvp.Value))) {
                stringBuilder.Append('\n');
                stringBuilder.Append(new string(' ', (indentationLevel + 1) * 4));
                hadLineBreak = true;
            }

            stringBuilder.Append("[ ");
            stringBuilder.Append(kvp.Key);
            stringBuilder.Append(" ] = ");
            Stringify(kvp.Value, indentationStyle, indentationLevel + 1, stringBuilder);
            stringBuilder.Append(", ");
        }

        stringBuilder.Length -= 2;

        if(!hadLineBreak) {
            stringBuilder.Append(" }");
        } else {
            stringBuilder.Append('\n');
            stringBuilder.Append(new string(' ', indentationLevel * 4));
            stringBuilder.Append('}');
        }
    }

    private static void StringifyEnumerable(object argument,
                                            IndentationStyle indentationStyle,
                                            int indentationLevel,
                                            StringBuilder stringBuilder) {
        var enumerable = CastEnumerable((IEnumerable)argument);

        var hadLineBreak = false;

        stringBuilder.Append("[  ");

        foreach(var element in enumerable) {
            if(indentationStyle == IndentationStyle.IndentNestedValues ||
               (indentationStyle == IndentationStyle.IndentNestedObjects && ShouldBeIndented(element))) {
                stringBuilder.Append('\n');
                stringBuilder.Append(new string(' ', (indentationLevel + 1) * 4));
                hadLineBreak = true;
            }

            Stringify(element, indentationStyle, indentationLevel + 1, stringBuilder);
            stringBuilder.Append(", ");
        }

        stringBuilder.Length -= 2;

        if(!hadLineBreak) {
            stringBuilder.Append(" ]");
        } else {
            stringBuilder.Append('\n');
            stringBuilder.Append(new string(' ', indentationLevel * 4));
            stringBuilder.Append(']');
        }
    }

    private static void StringifyObject(object argument,
                                        IndentationStyle indentationStyle,
                                        int indentationLevel,
                                        StringBuilder stringBuilder) {
        var type = argument.GetType();

        stringBuilder.Append(type.Name);

        (string name, object? value)[] propList;

        if(typeof(Exception).IsAssignableFrom(type)) {
            propList = type
                       .GetProperties()
                       .Where(pi => pi.GetCustomAttribute<JsonIgnoreAttribute>() is null)
                       .Select(uu => (name: uu.Name, value: uu.GetValue(argument)))
                       .Where(uu => uu.name != nameof(Exception.TargetSite))
                       .ToArray();
        } else {
            propList = type
                       .GetProperties()
                       .Where(pi => pi.GetCustomAttribute<JsonIgnoreAttribute>() is null)
                       .Select(uu => (name: uu.Name, value: uu.GetValue(argument)))
                       .ToArray();
        }

        if(propList.Length == 0) {
            return;
        }

        var hadLineBreak = false;

        stringBuilder.Append(" { ");

        foreach(var prop in propList) {
            if(indentationStyle == IndentationStyle.IndentNestedValues ||
               (indentationStyle == IndentationStyle.IndentNestedObjects && ShouldBeIndented(prop.value))) {
                stringBuilder.Append('\n');
                stringBuilder.Append(new string(' ', (indentationLevel + 1) * 4));
                hadLineBreak = true;
            }

            stringBuilder.Append(prop.name);
            stringBuilder.Append(" = ");
            Stringify(prop.value, indentationStyle, indentationLevel + 1, stringBuilder);
            stringBuilder.Append(", ");
        }

        stringBuilder.Length -= 2;

        if(!hadLineBreak) {
            stringBuilder.Append(" }");
        } else {
            stringBuilder.Append('\n');
            stringBuilder.Append(new string(' ', indentationLevel * 4));
            stringBuilder.Append('}');
        }
    }
}