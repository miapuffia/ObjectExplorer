namespace ObjectExplorer.UnitTests.Data;

using System.Collections;
using ObjectExplorer.UnitTests.Utils;
using PrettyString;

public class EnumerableData : IEnumerable<object?[]> {
    public IEnumerator<object?[]> GetEnumerator() {
        foreach(var x in TestGenerator.Enumerable(Array.Empty<object>(), "[ ]")) yield return x;

        foreach(var x in TestGenerator.Enumerable(
                    new object?[] { null },
                    "[ null ]",
                    "[ null ]",
                    "[\n    null\n]")) yield return x;

        foreach(var x in TestGenerator.Enumerable(
                    new object?[] { null, null },
                    "[ null, null ]",
                    "[ null, null ]",
                    "[\n    null,\n    null\n]")) yield return x;

        foreach(var x in TestGenerator.Enumerable(
                    new[] { 0 },
                    "[ 0 ]",
                    "[ 0 ]",
                    "[\n    0\n]")) yield return x;

        foreach(var x in TestGenerator.Enumerable(
                    new[] { 0, 1 },
                    "[ 0, 1 ]",
                    "[ 0, 1 ]",
                    "[\n    0,\n    1\n]")) yield return x;

        foreach(var x in TestGenerator.Enumerable(
                    new[] { "" },
                    "[  ]",
                    "[  ]",
                    "[\n    \n]")) yield return x;

        foreach(var x in TestGenerator.Enumerable(
                    new[] { "", "" },
                    "[ ,  ]",
                    "[ ,  ]",
                    "[\n    ,\n    \n]")) yield return x;

        foreach(var x in TestGenerator.Enumerable(
                    new[] { "test" },
                    "[ test ]",
                    "[ test ]",
                    "[\n    test\n]")) yield return x;

        foreach(var x in TestGenerator.Enumerable(
                    new[] { "test", "ing" },
                    "[ test, ing ]",
                    "[ test, ing ]",
                    "[\n    test,\n    ing\n]")) yield return x;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}