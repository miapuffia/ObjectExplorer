namespace ObjectExplorer.Extensions;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/// <summary>
///     Provides extension methods for working with <see langword="Type" /> values.
/// </summary>
public static class TypeExtensions {
    /// <param name="type">The Type to examine.</param>
    extension(Type type) {
        /// <summary>
        ///     Gets a value indicating whether a <see cref="Type" /> implements the <see cref="IEnumerable" /> interface.
        /// </summary>
        /// <returns>
        ///     <see langword="true" /> if <paramref name="type" /> implements <see cref="IEnumerable" />; otherwise,
        ///     <see langword="false" />.
        /// </returns>
        public bool ImplementsIEnumerable => type.GetInterfaces().Append(type)
                                                 .Any(x => x == typeof(IEnumerable) || (x.IsGenericType &&
                                                                                        x.GetGenericTypeDefinition() == typeof(IEnumerable<>)));

        /// <summary>
        ///     Gets a value indicating whether a <see cref="Type" /> implements the <see cref="IDictionary" /> interface.
        /// </summary>
        /// <returns>
        ///     <see langword="true" /> if <paramref name="type" /> implements <see cref="IDictionary" />; otherwise,
        ///     <see langword="false" />.
        /// </returns>
        public bool ImplementsIDictionary => type.GetInterfaces().Append(type)
                                                 .Any(x => x == typeof(IDictionary) || (x.IsGenericType &&
                                                                                        x.GetGenericTypeDefinition() == typeof(IDictionary<,>)));

        /// <summary>
        ///     Gets the <see cref="Type" /> of a generic <see cref="IEnumerable" />.
        /// </summary>
        /// <returns>
        ///     Generic <see cref="Type" /> if <paramref name="type" /> implements generic <see cref="IEnumerable" />; otherwise
        ///     <see langword="null" />.
        /// </returns>
        public Type? GetIEnumerableType() {
            // Type is Array
            // short-circuit if you expect lots of arrays
            if(type.IsArray)
                return type.GetElementType();

            // type is IEnumerable<T>;
            if(type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IEnumerable<>))
                return type.GetGenericArguments()[0];

            // type implements/extends IEnumerable<T>;
            var enumType = type.GetInterfaces()
                               .Where(t => t.IsGenericType &&
                                           t.GetGenericTypeDefinition() == typeof(IEnumerable<>))
                               .Select(t => t.GenericTypeArguments[0]).FirstOrDefault();

            if(enumType == null) {
                return null;
            }

            return enumType ?? type;
        }

        /// <summary>
        ///     Gets the <see cref="Type">Types</see> of a generic <see cref="IDictionary" />.
        /// </summary>
        /// <returns>
        ///     <see cref="Tuple" />&lt;<see cref="Type">TKey</see>,<see cref="Type">TValue</see>&gt; if <paramref name="type" />
        ///     implements generic <see cref="IDictionary" />; otherwise <see langword="null" />.
        /// </returns>
        public (Type TKey, Type TValue)? GetDictionaryTypes() {
            // type is IDictionary<T,V>;
            if(type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IDictionary<,>))
                return (type.GetGenericArguments()[0], type.GetGenericArguments()[1]);

            // type implements/extends IDictionary<T>;
            var enumType = type.GetInterfaces()
                               .Where(t => t.IsGenericType &&
                                           t.GetGenericTypeDefinition() == typeof(IDictionary<,>))
                               .Select(t => (t.GenericTypeArguments[0], t.GenericTypeArguments[1])).FirstOrDefault();

            if(enumType == default) {
                return null;
            }

            return enumType;
        }
    }
}