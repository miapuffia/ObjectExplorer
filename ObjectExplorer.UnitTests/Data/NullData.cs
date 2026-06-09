using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ObjectExplorer.UnitTests.Data;

using ObjectExplorer.UnitTests.Utils;
using PrettyString;

public class NullData : IEnumerable<object?[]> {
    public IEnumerator<object?[]> GetEnumerator() {
        foreach(var x in TestGenerator.Enumerable<object?>(null, "null")) yield return x;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
