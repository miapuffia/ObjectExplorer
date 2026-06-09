using ObjectExplorer.PrettyString;
using ObjectExplorer.UnitTests.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ObjectExplorer.UnitTests.Data;

public class StringData : IEnumerable<object?[]> {
    public IEnumerator<object?[]> GetEnumerator() {
        foreach(var x in TestGenerator.Enumerable("", "")) yield return x;
        foreach(var x in TestGenerator.Enumerable("test", "test")) yield return x;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
