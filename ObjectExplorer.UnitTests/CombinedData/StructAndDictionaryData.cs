using ObjectExplorer.PrettyString;
using ObjectExplorer.UnitTests.Containers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectExplorer.UnitTests.CombinedData;

using ObjectExplorer.UnitTests.Utils;
using System.Linq;
using Xunit;

public class StructAndDictionaryData {
    public static TheoryData<object, string, IndentationStyle> DictionaryOfStructs() => new() {
        TestGenerator.TheoryData<object>(new Dictionary<object, Structs.Empty> {}, "{ }"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Structs.Empty()}},
                                         "{ [ 0 ] = Empty }",
                                         "{\n    [ 0 ] = Empty\n}",
                                         "{\n    [ 0 ] = Empty\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Structs.Empty()}, {1, new Structs.Empty()}},
                                         "{ [ 0 ] = Empty, [ 1 ] = Empty }",
                                         "{\n    [ 0 ] = Empty,\n    [ 1 ] = Empty\n}",
                                         "{\n    [ 0 ] = Empty,\n    [ 1 ] = Empty\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Structs.With1PrimitivePrimary()}},
                                         "{ [ 0 ] = With1PrimitivePrimary }",
                                         "{\n    [ 0 ] = With1PrimitivePrimary\n}",
                                         "{\n    [ 0 ] = With1PrimitivePrimary\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Structs.With1PrimitiveField()}},
                                         "{ [ 0 ] = With1PrimitiveField { Int = 123 } }",
                                         "{\n    [ 0 ] = With1PrimitiveField { Int = 123 }\n}",
                                         "{\n    [ 0 ] = With1PrimitiveField {\n        Int = 123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Structs.With1PrimitiveProperty()}},
                                         "{ [ 0 ] = With1PrimitiveProperty { Int = 123 } }",
                                         "{\n    [ 0 ] = With1PrimitiveProperty { Int = 123 }\n}",
                                         "{\n    [ 0 ] = With1PrimitiveProperty {\n        Int = 123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Structs.With1PrimitivePrimary()}, {1, new Structs.With1PrimitivePrimary()}},
                                         "{ [ 0 ] = With1PrimitivePrimary, [ 1 ] = With1PrimitivePrimary }",
                                         "{\n    [ 0 ] = With1PrimitivePrimary,\n    [ 1 ] = With1PrimitivePrimary\n}",
                                         "{\n    [ 0 ] = With1PrimitivePrimary,\n    [ 1 ] = With1PrimitivePrimary\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Structs.With1PrimitiveField()}, {1, new Structs.With1PrimitiveField()}},
                                         "{ [ 0 ] = With1PrimitiveField { Int = 123 }, [ 1 ] = With1PrimitiveField { Int = 123 } }",
                                         "{\n    [ 0 ] = With1PrimitiveField { Int = 123 },\n    [ 1 ] = With1PrimitiveField { Int = 123 }\n}",
                                         "{\n    [ 0 ] = With1PrimitiveField {\n        Int = 123\n    },\n    [ 1 ] = With1PrimitiveField {\n        Int = 123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Structs.With1PrimitiveProperty()}, {1, new Structs.With1PrimitiveProperty()}},
                                         "{ [ 0 ] = With1PrimitiveProperty { Int = 123 }, [ 1 ] = With1PrimitiveProperty { Int = 123 } }",
                                         "{\n    [ 0 ] = With1PrimitiveProperty { Int = 123 },\n    [ 1 ] = With1PrimitiveProperty { Int = 123 }\n}",
                                         "{\n    [ 0 ] = With1PrimitiveProperty {\n        Int = 123\n    },\n    [ 1 ] = With1PrimitiveProperty {\n        Int = 123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Structs.WithMultiplePrimitivesPrimary()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesPrimary }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesPrimary\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesPrimary\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Structs.WithMultiplePrimitivesField()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 } }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 }\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Structs.WithMultiplePrimitivesProperty()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 } }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Structs.WithMultiplePrimitivesPrimary()}, {1, new Structs.WithMultiplePrimitivesPrimary()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesPrimary, [ 1 ] = WithMultiplePrimitivesPrimary }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesPrimary,\n    [ 1 ] = WithMultiplePrimitivesPrimary\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesPrimary,\n    [ 1 ] = WithMultiplePrimitivesPrimary\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Structs.WithMultiplePrimitivesField()}, {1, new Structs.WithMultiplePrimitivesField()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 }, [ 1 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 } }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 },\n    [ 1 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 }\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    },\n    [ 1 ] = WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new Structs.WithMultiplePrimitivesProperty()}, {1, new Structs.WithMultiplePrimitivesProperty()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }, [ 1 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 } }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 },\n    [ 1 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    },\n    [ 1 ] = WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    }\n}"),
    };
    
    public static TheoryData<object, string, IndentationStyle> DictionaryOfRecordStructs() => new() {
        TestGenerator.TheoryData<object>(new Dictionary<object, RecordStructs.Empty> {}, "{ }"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordStructs.Empty()}},
                                         "{ [ 0 ] = Empty }",
                                         "{\n    [ 0 ] = Empty\n}",
                                         "{\n    [ 0 ] = Empty\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordStructs.Empty()}, {1, new RecordStructs.Empty()}},
                                         "{ [ 0 ] = Empty, [ 1 ] = Empty }",
                                         "{\n    [ 0 ] = Empty,\n    [ 1 ] = Empty\n}",
                                         "{\n    [ 0 ] = Empty,\n    [ 1 ] = Empty\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordStructs.With1PrimitivePrimary()}},
                                         "{ [ 0 ] = With1PrimitivePrimary { Int = 123 } }",
                                         "{\n    [ 0 ] = With1PrimitivePrimary { Int = 123 }\n}",
                                         "{\n    [ 0 ] = With1PrimitivePrimary {\n        Int = 123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordStructs.With1PrimitiveField()}},
                                         "{ [ 0 ] = With1PrimitiveField { Int = 123 } }",
                                         "{\n    [ 0 ] = With1PrimitiveField { Int = 123 }\n}",
                                         "{\n    [ 0 ] = With1PrimitiveField {\n        Int = 123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordStructs.With1PrimitiveProperty()}},
                                         "{ [ 0 ] = With1PrimitiveProperty { Int = 123 } }",
                                         "{\n    [ 0 ] = With1PrimitiveProperty { Int = 123 }\n}",
                                         "{\n    [ 0 ] = With1PrimitiveProperty {\n        Int = 123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordStructs.With1PrimitivePrimary()}, {1, new RecordStructs.With1PrimitivePrimary()}},
                                         "{ [ 0 ] = With1PrimitivePrimary { Int = 123 }, [ 1 ] = With1PrimitivePrimary { Int = 123 } }",
                                         "{\n    [ 0 ] = With1PrimitivePrimary { Int = 123 },\n    [ 1 ] = With1PrimitivePrimary { Int = 123 }\n}",
                                         "{\n    [ 0 ] = With1PrimitivePrimary {\n        Int = 123\n    },\n    [ 1 ] = With1PrimitivePrimary {\n        Int = 123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordStructs.With1PrimitiveField()}, {1, new RecordStructs.With1PrimitiveField()}},
                                         "{ [ 0 ] = With1PrimitiveField { Int = 123 }, [ 1 ] = With1PrimitiveField { Int = 123 } }",
                                         "{\n    [ 0 ] = With1PrimitiveField { Int = 123 },\n    [ 1 ] = With1PrimitiveField { Int = 123 }\n}",
                                         "{\n    [ 0 ] = With1PrimitiveField {\n        Int = 123\n    },\n    [ 1 ] = With1PrimitiveField {\n        Int = 123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordStructs.With1PrimitiveProperty()}, {1, new RecordStructs.With1PrimitiveProperty()}},
                                         "{ [ 0 ] = With1PrimitiveProperty { Int = 123 }, [ 1 ] = With1PrimitiveProperty { Int = 123 } }",
                                         "{\n    [ 0 ] = With1PrimitiveProperty { Int = 123 },\n    [ 1 ] = With1PrimitiveProperty { Int = 123 }\n}",
                                         "{\n    [ 0 ] = With1PrimitiveProperty {\n        Int = 123\n    },\n    [ 1 ] = With1PrimitiveProperty {\n        Int = 123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordStructs.WithMultiplePrimitivesPrimary()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 } }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 }\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesPrimary {\n        Int = 123,\n        Double = 456.123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordStructs.WithMultiplePrimitivesField()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 } }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 }\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordStructs.WithMultiplePrimitivesProperty()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 } }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordStructs.WithMultiplePrimitivesPrimary()}, {1, new RecordStructs.WithMultiplePrimitivesPrimary()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 }, [ 1 ] = WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 } }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 },\n    [ 1 ] = WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 }\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesPrimary {\n        Int = 123,\n        Double = 456.123\n    },\n    [ 1 ] = WithMultiplePrimitivesPrimary {\n        Int = 123,\n        Double = 456.123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordStructs.WithMultiplePrimitivesField()}, {1, new RecordStructs.WithMultiplePrimitivesField()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 }, [ 1 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 } }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 },\n    [ 1 ] = WithMultiplePrimitivesField { Int = 123, Double = 456.123 }\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    },\n    [ 1 ] = WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    }\n}"),

        TestGenerator.TheoryData<object>(new Dictionary<object, object> {{0, new RecordStructs.WithMultiplePrimitivesProperty()}, {1, new RecordStructs.WithMultiplePrimitivesProperty()}},
                                         "{ [ 0 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }, [ 1 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 } }",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 },\n    [ 1 ] = WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }\n}",
                                         "{\n    [ 0 ] = WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    },\n    [ 1 ] = WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    }\n}"),
    };
}
