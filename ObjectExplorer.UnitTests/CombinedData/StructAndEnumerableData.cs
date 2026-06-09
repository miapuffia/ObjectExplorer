using ObjectExplorer.PrettyString;
using ObjectExplorer.UnitTests.Containers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectExplorer.UnitTests.CombinedData;

using ObjectExplorer.UnitTests.Utils;
using System.Linq;
using Xunit;

public class StructAndEnumerableData {
    public static TheoryData<object, string, IndentationStyle> EnumerableOfStructs() => new() {
        TestGenerator.TheoryData<object>(Array.Empty<Structs.Empty>(), "[ ]"),

        TestGenerator.TheoryData<object>(new[] {new Structs.Empty()},
                                         "[ Empty ]",
                                         "[\n    Empty\n]",
                                         "[\n    Empty\n]"),

        TestGenerator.TheoryData<object>(new[] {new Structs.Empty(), new Structs.Empty()},
                                         "[ Empty, Empty ]",
                                         "[\n    Empty,\n    Empty\n]",
                                         "[\n    Empty,\n    Empty\n]"),

        TestGenerator.TheoryData<object>(new[] {new Structs.With1PrimitivePrimary()},
                                         "[ With1PrimitivePrimary ]",
                                         "[\n    With1PrimitivePrimary\n]",
                                         "[\n    With1PrimitivePrimary\n]"),

        TestGenerator.TheoryData<object>(new[] {new Structs.With1PrimitiveField()},
                                         "[ With1PrimitiveField { Int = 123 } ]",
                                         "[\n    With1PrimitiveField { Int = 123 }\n]",
                                         "[\n    With1PrimitiveField {\n        Int = 123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new Structs.With1PrimitiveProperty()},
                                         "[ With1PrimitiveProperty { Int = 123 } ]",
                                         "[\n    With1PrimitiveProperty { Int = 123 }\n]",
                                         "[\n    With1PrimitiveProperty {\n        Int = 123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new Structs.With1PrimitivePrimary(), new Structs.With1PrimitivePrimary()},
                                         "[ With1PrimitivePrimary, With1PrimitivePrimary ]",
                                         "[\n    With1PrimitivePrimary,\n    With1PrimitivePrimary\n]",
                                         "[\n    With1PrimitivePrimary,\n    With1PrimitivePrimary\n]"),

        TestGenerator.TheoryData<object>(new[] {new Structs.With1PrimitiveField(), new Structs.With1PrimitiveField()},
                                         "[ With1PrimitiveField { Int = 123 }, With1PrimitiveField { Int = 123 } ]",
                                         "[\n    With1PrimitiveField { Int = 123 },\n    With1PrimitiveField { Int = 123 }\n]",
                                         "[\n    With1PrimitiveField {\n        Int = 123\n    },\n    With1PrimitiveField {\n        Int = 123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new Structs.With1PrimitiveProperty(), new Structs.With1PrimitiveProperty()},
                                         "[ With1PrimitiveProperty { Int = 123 }, With1PrimitiveProperty { Int = 123 } ]",
                                         "[\n    With1PrimitiveProperty { Int = 123 },\n    With1PrimitiveProperty { Int = 123 }\n]",
                                         "[\n    With1PrimitiveProperty {\n        Int = 123\n    },\n    With1PrimitiveProperty {\n        Int = 123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new Structs.WithMultiplePrimitivesPrimary()},
                                         "[ WithMultiplePrimitivesPrimary ]",
                                         "[\n    WithMultiplePrimitivesPrimary\n]",
                                         "[\n    WithMultiplePrimitivesPrimary\n]"),

        TestGenerator.TheoryData<object>(new[] {new Structs.WithMultiplePrimitivesField()},
                                         "[ WithMultiplePrimitivesField { Int = 123, Double = 456.123 } ]",
                                         "[\n    WithMultiplePrimitivesField { Int = 123, Double = 456.123 }\n]",
                                         "[\n    WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new Structs.WithMultiplePrimitivesProperty()},
                                         "[ WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 } ]",
                                         "[\n    WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }\n]",
                                         "[\n    WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new Structs.WithMultiplePrimitivesPrimary(), new Structs.WithMultiplePrimitivesPrimary()},
                                         "[ WithMultiplePrimitivesPrimary, WithMultiplePrimitivesPrimary ]",
                                         "[\n    WithMultiplePrimitivesPrimary,\n    WithMultiplePrimitivesPrimary\n]",
                                         "[\n    WithMultiplePrimitivesPrimary,\n    WithMultiplePrimitivesPrimary\n]"),

        TestGenerator.TheoryData<object>(new[] {new Structs.WithMultiplePrimitivesField(), new Structs.WithMultiplePrimitivesField()},
                                         "[ WithMultiplePrimitivesField { Int = 123, Double = 456.123 }, WithMultiplePrimitivesField { Int = 123, Double = 456.123 } ]",
                                         "[\n    WithMultiplePrimitivesField { Int = 123, Double = 456.123 },\n    WithMultiplePrimitivesField { Int = 123, Double = 456.123 }\n]",
                                         "[\n    WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    },\n    WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new Structs.WithMultiplePrimitivesProperty(), new Structs.WithMultiplePrimitivesProperty()},
                                         "[ WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }, WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 } ]",
                                         "[\n    WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 },\n    WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }\n]",
                                         "[\n    WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    },\n    WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    }\n]"),
    };
    
    public static TheoryData<object, string, IndentationStyle> EnumerableOfRecordStructs() => new() {
        TestGenerator.TheoryData<object>(Array.Empty<RecordStructs.Empty>(), "[ ]"),

        TestGenerator.TheoryData<object>(new[] {new RecordStructs.Empty()},
                                         "[ Empty ]",
                                         "[\n    Empty\n]",
                                         "[\n    Empty\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordStructs.Empty(), new RecordStructs.Empty()},
                                         "[ Empty, Empty ]",
                                         "[\n    Empty,\n    Empty\n]",
                                         "[\n    Empty,\n    Empty\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordStructs.With1PrimitivePrimary()},
                                         "[ With1PrimitivePrimary { Int = 123 } ]",
                                         "[\n    With1PrimitivePrimary { Int = 123 }\n]",
                                         "[\n    With1PrimitivePrimary {\n        Int = 123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordStructs.With1PrimitiveField()},
                                         "[ With1PrimitiveField { Int = 123 } ]",
                                         "[\n    With1PrimitiveField { Int = 123 }\n]",
                                         "[\n    With1PrimitiveField {\n        Int = 123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordStructs.With1PrimitiveProperty()},
                                         "[ With1PrimitiveProperty { Int = 123 } ]",
                                         "[\n    With1PrimitiveProperty { Int = 123 }\n]",
                                         "[\n    With1PrimitiveProperty {\n        Int = 123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordStructs.With1PrimitivePrimary(), new RecordStructs.With1PrimitivePrimary()},
                                         "[ With1PrimitivePrimary { Int = 123 }, With1PrimitivePrimary { Int = 123 } ]",
                                         "[\n    With1PrimitivePrimary { Int = 123 },\n    With1PrimitivePrimary { Int = 123 }\n]",
                                         "[\n    With1PrimitivePrimary {\n        Int = 123\n    },\n    With1PrimitivePrimary {\n        Int = 123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordStructs.With1PrimitiveField(), new RecordStructs.With1PrimitiveField()},
                                         "[ With1PrimitiveField { Int = 123 }, With1PrimitiveField { Int = 123 } ]",
                                         "[\n    With1PrimitiveField { Int = 123 },\n    With1PrimitiveField { Int = 123 }\n]",
                                         "[\n    With1PrimitiveField {\n        Int = 123\n    },\n    With1PrimitiveField {\n        Int = 123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordStructs.With1PrimitiveProperty(), new RecordStructs.With1PrimitiveProperty()},
                                         "[ With1PrimitiveProperty { Int = 123 }, With1PrimitiveProperty { Int = 123 } ]",
                                         "[\n    With1PrimitiveProperty { Int = 123 },\n    With1PrimitiveProperty { Int = 123 }\n]",
                                         "[\n    With1PrimitiveProperty {\n        Int = 123\n    },\n    With1PrimitiveProperty {\n        Int = 123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordStructs.WithMultiplePrimitivesPrimary()},
                                         "[ WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 } ]",
                                         "[\n    WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 }\n]",
                                         "[\n    WithMultiplePrimitivesPrimary {\n        Int = 123,\n        Double = 456.123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordStructs.WithMultiplePrimitivesField()},
                                         "[ WithMultiplePrimitivesField { Int = 123, Double = 456.123 } ]",
                                         "[\n    WithMultiplePrimitivesField { Int = 123, Double = 456.123 }\n]",
                                         "[\n    WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordStructs.WithMultiplePrimitivesProperty()},
                                         "[ WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 } ]",
                                         "[\n    WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }\n]",
                                         "[\n    WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordStructs.WithMultiplePrimitivesPrimary(), new RecordStructs.WithMultiplePrimitivesPrimary()},
                                         "[ WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 }, WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 } ]",
                                         "[\n    WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 },\n    WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 }\n]",
                                         "[\n    WithMultiplePrimitivesPrimary {\n        Int = 123,\n        Double = 456.123\n    },\n    WithMultiplePrimitivesPrimary {\n        Int = 123,\n        Double = 456.123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordStructs.WithMultiplePrimitivesField(), new RecordStructs.WithMultiplePrimitivesField()},
                                         "[ WithMultiplePrimitivesField { Int = 123, Double = 456.123 }, WithMultiplePrimitivesField { Int = 123, Double = 456.123 } ]",
                                         "[\n    WithMultiplePrimitivesField { Int = 123, Double = 456.123 },\n    WithMultiplePrimitivesField { Int = 123, Double = 456.123 }\n]",
                                         "[\n    WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    },\n    WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordStructs.WithMultiplePrimitivesProperty(), new RecordStructs.WithMultiplePrimitivesProperty()},
                                         "[ WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }, WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 } ]",
                                         "[\n    WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 },\n    WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }\n]",
                                         "[\n    WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    },\n    WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    }\n]"),
    };
}
