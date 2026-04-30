// <copyright file="ExceptionConverter.cs" company="Air Line Pilots Association">
// Copyright (c) Air Line Pilots Association. All rights reserved.
// </copyright>

namespace ObjectExplorer.Json;

using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>
///     Provides a <see cref="JsonConverter" /> to serialize <see cref="Exception" />.
/// </summary>
/// <typeparam name="TExceptionType">The type of the <see cref="Exception" />.</typeparam>
public class ExceptionConverter<TExceptionType> : JsonConverter<TExceptionType>
{
    /// <inheritdoc/>
    public override bool CanConvert(Type typeToConvert)
    {
        return typeof(Exception).IsAssignableFrom(typeToConvert);
    }

    /// <inheritdoc/>
    public override TExceptionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotSupportedException("Deserializing exceptions is not allowed");
    }

    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer, TExceptionType value, JsonSerializerOptions options)
    {
        var serializableProperties = value.GetType()
            .GetProperties()
            .Select(uu => new { uu.Name, Value = uu.GetValue(value) })
            .Where(uu => uu.Name != nameof(Exception.TargetSite));

        var propList = serializableProperties.ToList();

        if (propList.Count == 0)
        {
            // Nothing to write
            return;
        }

        writer.WriteStartObject();

        foreach (var prop in propList)
        {
            writer.WritePropertyName(prop.Name);
            JsonSerializer.Serialize(writer, prop.Value, options);
        }

        writer.WriteEndObject();
    }
}