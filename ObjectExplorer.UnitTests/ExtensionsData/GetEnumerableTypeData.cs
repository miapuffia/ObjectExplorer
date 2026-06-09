using ObjectExplorer.Extensions;
using ObjectExplorer.UnitTests.Containers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ObjectExplorer.UnitTests.ExtensionsData;

public static class GetEnumerableTypeData {
    public static TheoryData<Type?, Type?> Data() => new() {
        { Array.Empty<int>().GetType().GetEnumerableType(), typeof(int) },
        { Array.Empty<string>().GetType().GetEnumerableType(), typeof(string) },
        { Array.Empty<Color>().GetType().GetEnumerableType(), typeof(Color) },
        { Array.Empty<Classes.Empty>().GetType().GetEnumerableType(), typeof(Classes.Empty) },
        
        { Enumerable.Empty<int>().GetType().GetEnumerableType(), typeof(int) },
        { Enumerable.Empty<string>().GetType().GetEnumerableType(), typeof(string) },
        { Enumerable.Empty<Color>().GetType().GetEnumerableType(), typeof(Color) },
        { Enumerable.Empty<Classes.Empty>().GetType().GetEnumerableType(), typeof(Classes.Empty) },
        
        { new List<int>().GetType().GetEnumerableType(), typeof(int) },
        { new List<string>().GetType().GetEnumerableType(), typeof(string) },
        { new List<Color>().GetType().GetEnumerableType(), typeof(Color) },
        { new List<Classes.Empty>().GetType().GetEnumerableType(), typeof(Classes.Empty) },
        
        { typeof(IEnumerable<int>).GetEnumerableType(), typeof(int) },
        { typeof(IEnumerable<string>).GetEnumerableType(), typeof(string) },
        { typeof(IEnumerable<Color>).GetEnumerableType(), typeof(Color) },
        { typeof(IEnumerable<Classes.Empty>).GetEnumerableType(), typeof(Classes.Empty) },
        
        { typeof(int).GetEnumerableType(), null },
    };
}
