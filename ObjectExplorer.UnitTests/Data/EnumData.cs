using ObjectExplorer.PrettyString;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ObjectExplorer.UnitTests.Data;

using Containers;
using ObjectExplorer.UnitTests.Utils;

internal class EnumData : IEnumerable<object?[]> {
    public IEnumerator<object?[]> GetEnumerator() {
        foreach(var x in TestGenerator.Enumerable((Enums.Empty) 0, "0")) yield return x;
        foreach(var x in TestGenerator.Enumerable(Enums.WithValue.Value, "Value")) yield return x;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
