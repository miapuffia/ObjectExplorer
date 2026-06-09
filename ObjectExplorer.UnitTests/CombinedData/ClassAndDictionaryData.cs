using ObjectExplorer.PrettyString;
using ObjectExplorer.UnitTests.Containers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectExplorer.UnitTests.CombinedData;

using ObjectExplorer.UnitTests.Utils;
using System.Linq;
using Xunit;

public class ClassAndDictionaryData {
    public static TheoryData<object, string, IndentationStyle> DictionaryOfClasses() => new() {
        TestGenerator.TheoryData<object>(new Dictionary<object, Classes.Empty> {}, "{ }"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Classes.Empty()}},
                                         "{ [ 0 ] = Empty }",
                                         "{\n    [ 0 ] = Empty\n}",
                                         "{\n    [ 0 ] = Empty\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Classes.Empty()}, {1, new Classes.Empty()}},
                                         "{ [ 0 ] = Empty, [ 1 ] = Empty }",
                                         "{\n    [ 0 ] = Empty,\n    [ 1 ] = Empty\n}",
                                         "{\n    [ 0 ] = Empty,\n    [ 1 ] = Empty\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Classes.With1PrimitivePrimary()}},
                                         "{ [ 0 ] = With1PrimitivePrimary }",
                                         "{\n    [ 0 ] = With1PrimitivePrimary\n}",
                                         "{\n    [ 0 ] = With1PrimitivePrimary\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Classes.With1PrimitiveField()}},
                                         "{ [ 0 ] = With1PrimitiveField { Int = 123 } }",
                                         "{\n    [ 0 ] = With1PrimitiveField { Int = 123 }\n}",
                                         "{\n    [ 0 ] = With1PrimitiveField {\n        Int = 123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Classes.With1PrimitiveProperty()}},
                                         "{ [ 0 ] = With1PrimitiveProperty { Int = 123 } }",
                                         "{\n    [ 0 ] = With1PrimitiveProperty { Int = 123 }\n}",
                                         "{\n    [ 0 ] = With1PrimitiveProperty {\n        Int = 123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Classes.With1PrimitivePrimary()}, {1, new Classes.With1PrimitivePrimary()}},
                                         "{ [ 0 ] = With1PrimitivePrimary, [ 1 ] = With1PrimitivePrimary }",
                                         "{\n    [ 0 ] = With1PrimitivePrimary,\n    [ 1 ] = With1PrimitivePrimary\n}",
                                         "{\n    [ 0 ] = With1PrimitivePrimary,\n    [ 1 ] = With1PrimitivePrimary\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Classes.With1PrimitiveField()}, {1, new Classes.With1PrimitiveField()}},
                                         "{ [ 0 ] = With1PrimitiveField { Int = 123 }, [ 1 ] = With1PrimitiveField { Int = 123 } }",
                                         "{\n    [ 0 ] = With1PrimitiveField { Int = 123 },\n    [ 1 ] = With1PrimitiveField { Int = 123 }\n}",
                                         "{\n    [ 0 ] = With1PrimitiveField {\n        Int = 123\n    },\n    [ 1 ] = With1PrimitiveField {\n        Int = 123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Classes.With1PrimitiveProperty()}, {1, new Classes.With1PrimitiveProperty()}},
                                         "{ [ 0 ] = With1PrimitiveProperty { Int = 123 }, [ 1 ] = With1PrimitiveProperty { Int = 123 } }",
                                         "{\n    [ 0 ] = With1PrimitiveProperty { Int = 123 },\n    [ 1 ] = With1PrimitiveProperty { Int = 123 }\n}",
                                         "{\n    [ 0 ] = With1PrimitiveProperty {\n        Int = 123\n    },\n    [ 1 ] = With1PrimitiveProperty {\n        Int = 123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Classes.WithMultiplePrimitivesPrimary()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesPrimary }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesPrimary\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesPrimary\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Classes.WithMultiplePrimitivesField()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 } }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 }\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Classes.WithMultiplePrimitivesProperty()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 } }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Classes.WithMultiplePrimitivesPrimary()}, {1, new Classes.WithMultiplePrimitivesPrimary()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesPrimary, [ 1 ] = WithMultiplePrimitivesPrimary }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesPrimary,\n    [ 1 ] = WithMultiplePrimitivesPrimary\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesPrimary,\n    [ 1 ] = WithMultiplePrimitivesPrimary\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Classes.WithMultiplePrimitivesField()}, {1, new Classes.WithMultiplePrimitivesField()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 }, [ 1 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 } }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 },\n    [ 1 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 }\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    },\n    [ 1 ] = WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Classes.WithMultiplePrimitivesProperty()}, {1, new Classes.WithMultiplePrimitivesProperty()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }, [ 1 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 } }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 },\n    [ 1 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    },\n    [ 1 ] = WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Classes.With1CyclicalField()}},
                                         "{ [ 0 ] = With1CyclicalField { Child = With1CyclicalField (skipped) } }",
                                         "{\n    [ 0 ] = With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    }\n}",
                                         "{\n    [ 0 ] = With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Classes.With1CyclicalProperty()}},
                                         "{ [ 0 ] = With1CyclicalProperty { Child = With1CyclicalProperty (skipped) } }",
                                         "{\n    [ 0 ] = With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    }\n}",
                                         "{\n    [ 0 ] = With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Classes.With1CyclicalField()}, {1, new Classes.With1CyclicalField()}},
                                         "{ [ 0 ] = With1CyclicalField { Child = With1CyclicalField (skipped) }, [ 1 ] = With1CyclicalField { Child = With1CyclicalField (skipped) } }",
                                         "{\n    [ 0 ] = With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    },\n    [ 1 ] = With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    }\n}",
                                         "{\n    [ 0 ] = With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    },\n    [ 1 ] = With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Classes.With1CyclicalProperty()}, {1, new Classes.With1CyclicalProperty()}},
                                         "{ [ 0 ] = With1CyclicalProperty { Child = With1CyclicalProperty (skipped) }, [ 1 ] = With1CyclicalProperty { Child = With1CyclicalProperty (skipped) } }",
                                         "{\n    [ 0 ] = With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    },\n    [ 1 ] = With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    }\n}",
                                         "{\n    [ 0 ] = With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    },\n    [ 1 ] = With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    }\n}"),
    };
    
    public static TheoryData<object, string, IndentationStyle> DictionaryOfRecordClasses() => new() {
        TestGenerator.TheoryData<object>(new Dictionary<object, RecordClasses.Empty> {}, "{ }"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordClasses.Empty()}},
                                         "{ [ 0 ] = Empty }",
                                         "{\n    [ 0 ] = Empty\n}",
                                         "{\n    [ 0 ] = Empty\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordClasses.Empty()}, {1, new RecordClasses.Empty()}},
                                         "{ [ 0 ] = Empty, [ 1 ] = Empty }",
                                         "{\n    [ 0 ] = Empty,\n    [ 1 ] = Empty\n}",
                                         "{\n    [ 0 ] = Empty,\n    [ 1 ] = Empty\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordClasses.With1PrimitivePrimary()}},
                                         "{ [ 0 ] = With1PrimitivePrimary { Int = 123 } }",
                                         "{\n    [ 0 ] = With1PrimitivePrimary { Int = 123 }\n}",
                                         "{\n    [ 0 ] = With1PrimitivePrimary {\n        Int = 123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordClasses.With1PrimitiveField()}},
                                         "{ [ 0 ] = With1PrimitiveField { Int = 123 } }",
                                         "{\n    [ 0 ] = With1PrimitiveField { Int = 123 }\n}",
                                         "{\n    [ 0 ] = With1PrimitiveField {\n        Int = 123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordClasses.With1PrimitiveProperty()}},
                                         "{ [ 0 ] = With1PrimitiveProperty { Int = 123 } }",
                                         "{\n    [ 0 ] = With1PrimitiveProperty { Int = 123 }\n}",
                                         "{\n    [ 0 ] = With1PrimitiveProperty {\n        Int = 123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordClasses.With1PrimitivePrimary()}, {1, new RecordClasses.With1PrimitivePrimary()}},
                                         "{ [ 0 ] = With1PrimitivePrimary { Int = 123 }, [ 1 ] = With1PrimitivePrimary { Int = 123 } }",
                                         "{\n    [ 0 ] = With1PrimitivePrimary { Int = 123 },\n    [ 1 ] = With1PrimitivePrimary { Int = 123 }\n}",
                                         "{\n    [ 0 ] = With1PrimitivePrimary {\n        Int = 123\n    },\n    [ 1 ] = With1PrimitivePrimary {\n        Int = 123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordClasses.With1PrimitiveField()}, {1, new RecordClasses.With1PrimitiveField()}},
                                         "{ [ 0 ] = With1PrimitiveField { Int = 123 }, [ 1 ] = With1PrimitiveField { Int = 123 } }",
                                         "{\n    [ 0 ] = With1PrimitiveField { Int = 123 },\n    [ 1 ] = With1PrimitiveField { Int = 123 }\n}",
                                         "{\n    [ 0 ] = With1PrimitiveField {\n        Int = 123\n    },\n    [ 1 ] = With1PrimitiveField {\n        Int = 123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordClasses.With1PrimitiveProperty()}, {1, new RecordClasses.With1PrimitiveProperty()}},
                                         "{ [ 0 ] = With1PrimitiveProperty { Int = 123 }, [ 1 ] = With1PrimitiveProperty { Int = 123 } }",
                                         "{\n    [ 0 ] = With1PrimitiveProperty { Int = 123 },\n    [ 1 ] = With1PrimitiveProperty { Int = 123 }\n}",
                                         "{\n    [ 0 ] = With1PrimitiveProperty {\n        Int = 123\n    },\n    [ 1 ] = With1PrimitiveProperty {\n        Int = 123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordClasses.WithMultiplePrimitivesPrimary()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 } }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 }\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesPrimary {\n        Int = 123,\n        Double = 456.123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordClasses.WithMultiplePrimitivesField()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 } }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 }\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordClasses.WithMultiplePrimitivesProperty()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 } }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordClasses.WithMultiplePrimitivesPrimary()}, {1, new RecordClasses.WithMultiplePrimitivesPrimary()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 }, [ 1 ] = WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 } }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 },\n    [ 1 ] = WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 }\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesPrimary {\n        Int = 123,\n        Double = 456.123\n    },\n    [ 1 ] = WithMultiplePrimitivesPrimary {\n        Int = 123,\n        Double = 456.123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordClasses.WithMultiplePrimitivesField()}, {1, new RecordClasses.WithMultiplePrimitivesField()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 }, [ 1 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 } }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 },\n    [ 1 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 }\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    },\n    [ 1 ] = WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordClasses.WithMultiplePrimitivesProperty()}, {1, new RecordClasses.WithMultiplePrimitivesProperty()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }, [ 1 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 } }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 },\n    [ 1 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    },\n    [ 1 ] = WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordClasses.With1CyclicalField()}},
                                         "{ [ 0 ] = With1CyclicalField { Child = With1CyclicalField (skipped) } }",
                                         "{\n    [ 0 ] = With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    }\n}",
                                         "{\n    [ 0 ] = With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordClasses.With1CyclicalProperty()}},
                                         "{ [ 0 ] = With1CyclicalProperty { Child = With1CyclicalProperty (skipped) } }",
                                         "{\n    [ 0 ] = With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    }\n}",
                                         "{\n    [ 0 ] = With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordClasses.With1CyclicalField()}, {1, new RecordClasses.With1CyclicalField()}},
                                         "{ [ 0 ] = With1CyclicalField { Child = With1CyclicalField (skipped) }, [ 1 ] = With1CyclicalField { Child = With1CyclicalField (skipped) } }",
                                         "{\n    [ 0 ] = With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    },\n    [ 1 ] = With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    }\n}",
                                         "{\n    [ 0 ] = With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    },\n    [ 1 ] = With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordClasses.With1CyclicalProperty()}, {1, new RecordClasses.With1CyclicalProperty()}},
                                         "{ [ 0 ] = With1CyclicalProperty { Child = With1CyclicalProperty (skipped) }, [ 1 ] = With1CyclicalProperty { Child = With1CyclicalProperty (skipped) } }",
                                         "{\n    [ 0 ] = With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    },\n    [ 1 ] = With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    }\n}",
                                         "{\n    [ 0 ] = With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    },\n    [ 1 ] = With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    }\n}"),
    };
}
