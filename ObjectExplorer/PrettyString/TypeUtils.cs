namespace ObjectExplorer.PrettyString;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;

internal static class TypeUtils {
    internal static IEnumerable<DictionaryEntry> CastDict(IDictionary dictionary) {
        foreach(DictionaryEntry entry in dictionary) {
            yield return entry;
        }
    }

    internal static IEnumerable<object> CastEnumerable(IEnumerable enumerable) {
        foreach(var entry in enumerable) {
            yield return entry;
        }
    }

    internal static bool ShouldBeIndented(object? argument) {
        return argument is not (null or string) && !argument.GetType().IsPrimitive && !argument.GetType().IsEnum;
    }

    internal static (string name, object? property)[] GetProperties(object argument, Type type) {
        (string name, object? property)[] propList;

        if(typeof(Exception).IsAssignableFrom(type)) {
            propList = type
                       .GetProperties()
                       .Where(pi => pi.GetCustomAttribute<JsonIgnoreAttribute>() is null && !pi.PropertyType.IsByRefLike)
                       .Select(pi => (name: pi.Name, value: pi.GetValue(argument)))
                       .Where(pi => pi.name != nameof(Exception.TargetSite))
                       .Concat(type
                               .GetFields()
                               .Where(fi => fi.GetCustomAttribute<JsonIgnoreAttribute>() is null && !fi.FieldType.IsByRefLike)
                               .Select(fi => (name: fi.Name, value: fi.GetValue(argument)))
                               .Where(fi => fi.name != nameof(Exception.TargetSite)))
                       .ToArray();
        } else {
            propList = type
                       .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                       .Where(pi => pi.GetCustomAttribute<JsonIgnoreAttribute>() is null && !pi.PropertyType.IsByRefLike)
                       .Select(pi => (name: pi.Name, value: pi.GetValue(argument)))
                       .Concat(type
                               .GetFields(BindingFlags.Instance | BindingFlags.Public)
                               .Where(fi => fi.GetCustomAttribute<JsonIgnoreAttribute>() is null && !fi.FieldType.IsByRefLike)
                               .Select(fi => (name: fi.Name, value: fi.GetValue(argument))))
                       .ToArray();
        }

        return propList;
    }
}
