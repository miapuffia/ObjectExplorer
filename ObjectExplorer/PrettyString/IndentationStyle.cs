namespace ObjectExplorer.PrettyString;

/// <summary>
///     Specifies PrettyString indentation style options.
/// </summary>
public enum IndentationStyle
{
    /// <summary>
    ///     Specifies that there should be no indentation.
    /// </summary>
    NoIndentation,

    /// <summary>
    ///     Specifies that nested objects should be indented but values should not.
    /// </summary>
    IndentNestedObjects,

    /// <summary>
    ///     Specifies that nested objects and values should be indented.
    /// </summary>
    IndentNestedValues,
}