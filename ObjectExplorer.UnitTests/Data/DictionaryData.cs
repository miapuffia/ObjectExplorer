namespace ObjectExplorer.UnitTests.Data;

using ObjectExplorer.UnitTests.Utils;
using System.Collections;

public class DictionaryData : IEnumerable<object?[]> {
    public IEnumerator<object?[]> GetEnumerator() {
        foreach(var x in TestGenerator.Enumerable(new Dictionary<object, object?>(), "{ }")) yield return x;

        foreach(var x in TestGenerator.Enumerable(
                    new Dictionary<object, object?> { { 0, null } },
                    "{ [ 0 ] = null }",
                    "{ [ 0 ] = null }",
                    "{\n    [ 0 ] = null\n}")) yield return x;

        foreach(var x in TestGenerator.Enumerable(
                    new Dictionary<object, object?> { { 0, null }, { 1, null } },
                    "{ [ 0 ] = null, [ 1 ] = null }",
                    "{ [ 0 ] = null, [ 1 ] = null }",
                    "{\n    [ 0 ] = null,\n    [ 1 ] = null\n}")) yield return x;

        foreach(var x in TestGenerator.Enumerable(
                    new Dictionary<object, object?> { { 0, 0 } },
                    "{ [ 0 ] = 0 }",
                    "{ [ 0 ] = 0 }",
                    "{\n    [ 0 ] = 0\n}")) yield return x;

        foreach(var x in TestGenerator.Enumerable(
                    new Dictionary<object, object?> { { 0, 0 }, { 1, 1 } },
                    "{ [ 0 ] = 0, [ 1 ] = 1 }",
                    "{ [ 0 ] = 0, [ 1 ] = 1 }",
                    "{\n    [ 0 ] = 0,\n    [ 1 ] = 1\n}")) yield return x;

        foreach(var x in TestGenerator.Enumerable(
                    new Dictionary<object, object?> { { 0, "" } },
                    "{ [ 0 ] =  }",
                    "{ [ 0 ] =  }",
                    "{\n    [ 0 ] = \n}")) yield return x;

        foreach(var x in TestGenerator.Enumerable(
                    new Dictionary<object, object?> { { 0, "" }, { 1, "" } },
                    "{ [ 0 ] = , [ 1 ] =  }",
                    "{ [ 0 ] = , [ 1 ] =  }",
                    "{\n    [ 0 ] = ,\n    [ 1 ] = \n}")) yield return x;

        foreach(var x in TestGenerator.Enumerable(
                    new Dictionary<object, object?> { { 0, "test" } },
                    "{ [ 0 ] = test }",
                    "{ [ 0 ] = test }",
                    "{\n    [ 0 ] = test\n}")) yield return x;

        foreach(var x in TestGenerator.Enumerable(
                    new Dictionary<object, object?> { { 0, "test" }, { 1, "ing" } },
                    "{ [ 0 ] = test, [ 1 ] = ing }",
                    "{ [ 0 ] = test, [ 1 ] = ing }",
                    "{\n    [ 0 ] = test,\n    [ 1 ] = ing\n}")) yield return x;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}