using ObjectExplorer.Extensions;
using ObjectExplorer.UnitTests.Containers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ObjectExplorer.UnitTests.ExtensionsData;

public static class GetDictionaryTypesData {
    public static TheoryData<(Type, Type)?, (Type, Type)?> Data() => new() {
        { new Dictionary<int, string>().GetType().GetDictionaryTypes(), (typeof(int), typeof(string)) },
        { new Dictionary<Color, Classes.Empty>().GetType().GetDictionaryTypes(), (typeof(Color), typeof(Classes.Empty)) },

        { new SortedList<int, string>().GetType().GetDictionaryTypes(), (typeof(int), typeof(string)) },
        { new SortedList<Color, Classes.Empty>().GetType().GetDictionaryTypes(), (typeof(Color), typeof(Classes.Empty)) },
        
        { typeof(IDictionary<int, string>).GetDictionaryTypes(), (typeof(int), typeof(string)) },
        { typeof(IDictionary<Color, Classes.Empty>).GetDictionaryTypes(), (typeof(Color), typeof(Classes.Empty)) },
        
        { typeof(int).GetDictionaryTypes(), null },
    };
}
