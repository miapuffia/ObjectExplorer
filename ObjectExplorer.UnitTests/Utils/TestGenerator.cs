using ObjectExplorer.PrettyString;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectExplorer.UnitTests.Utils;

public static class TestGenerator {
    public static IEnumerable<object?[]> Enumerable<T>(T testObject, string expected) {
        yield return [testObject, expected, IndentationStyle.NoIndentation];
        yield return [testObject, expected, IndentationStyle.IndentNestedObjects];
        yield return [testObject, expected, IndentationStyle.IndentNestedValues];
    }
    
    public static IEnumerable<object?[]> Enumerable<T>(T testObject, string expectedNoIndentation, string expectedIndentNestedObjects, string expectedIndentNestedValues) {
        yield return [testObject, expectedNoIndentation, IndentationStyle.NoIndentation];
        yield return [testObject, expectedIndentNestedObjects, IndentationStyle.IndentNestedObjects];
        yield return [testObject, expectedIndentNestedValues, IndentationStyle.IndentNestedValues];
    }

    public static TheoryData<T, string, IndentationStyle> TheoryData<T>(T testObject, string expected) => new() {
        { testObject, expected, IndentationStyle.NoIndentation },
        { testObject, expected, IndentationStyle.IndentNestedObjects },
        { testObject, expected, IndentationStyle.IndentNestedValues },
    };

    public static TheoryData<T, string, IndentationStyle> TheoryData<T>(T testObject, string expectedNoIndentation, string expectedIndentNestedObjects, string expectedIndentNestedValues) => new() {
        { testObject, expectedNoIndentation, IndentationStyle.NoIndentation },
        { testObject, expectedIndentNestedObjects, IndentationStyle.IndentNestedObjects },
        { testObject, expectedIndentNestedValues, IndentationStyle.IndentNestedValues },
    };
}
