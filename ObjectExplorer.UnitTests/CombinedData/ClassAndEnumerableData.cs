using ObjectExplorer.PrettyString;
using ObjectExplorer.UnitTests.Containers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectExplorer.UnitTests.CombinedData;

using ObjectExplorer.UnitTests.Utils;
using System.Linq;
using Xunit;

public class ClassAndEnumerableData {
    public static TheoryData<object, string, IndentationStyle> EnumerableOfClasses() => new() {
        TestGenerator.TheoryData<object>(Array.Empty<Classes.Empty>(), "[ ]"),

        TestGenerator.TheoryData<object>(new[] {new Classes.Empty()},
                                         "[ Empty ]",
                                         "[\n    Empty\n]",
                                         "[\n    Empty\n]"),

        TestGenerator.TheoryData<object>(new[] {new Classes.Empty(), new Classes.Empty()},
                                         "[ Empty, Empty ]",
                                         "[\n    Empty,\n    Empty\n]",
                                         "[\n    Empty,\n    Empty\n]"),

        TestGenerator.TheoryData<object>(new[] {new Classes.With1PrimitivePrimary()},
                                         "[ With1PrimitivePrimary ]",
                                         "[\n    With1PrimitivePrimary\n]",
                                         "[\n    With1PrimitivePrimary\n]"),

        TestGenerator.TheoryData<object>(new[] {new Classes.With1PrimitiveField()},
                                         "[ With1PrimitiveField { Int = 123 } ]",
                                         "[\n    With1PrimitiveField { Int = 123 }\n]",
                                         "[\n    With1PrimitiveField {\n        Int = 123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new Classes.With1PrimitiveProperty()},
                                         "[ With1PrimitiveProperty { Int = 123 } ]",
                                         "[\n    With1PrimitiveProperty { Int = 123 }\n]",
                                         "[\n    With1PrimitiveProperty {\n        Int = 123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new Classes.With1PrimitivePrimary(), new Classes.With1PrimitivePrimary()},
                                         "[ With1PrimitivePrimary, With1PrimitivePrimary ]",
                                         "[\n    With1PrimitivePrimary,\n    With1PrimitivePrimary\n]",
                                         "[\n    With1PrimitivePrimary,\n    With1PrimitivePrimary\n]"),

        TestGenerator.TheoryData<object>(new[] {new Classes.With1PrimitiveField(), new Classes.With1PrimitiveField()},
                                         "[ With1PrimitiveField { Int = 123 }, With1PrimitiveField { Int = 123 } ]",
                                         "[\n    With1PrimitiveField { Int = 123 },\n    With1PrimitiveField { Int = 123 }\n]",
                                         "[\n    With1PrimitiveField {\n        Int = 123\n    },\n    With1PrimitiveField {\n        Int = 123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new Classes.With1PrimitiveProperty(), new Classes.With1PrimitiveProperty()},
                                         "[ With1PrimitiveProperty { Int = 123 }, With1PrimitiveProperty { Int = 123 } ]",
                                         "[\n    With1PrimitiveProperty { Int = 123 },\n    With1PrimitiveProperty { Int = 123 }\n]",
                                         "[\n    With1PrimitiveProperty {\n        Int = 123\n    },\n    With1PrimitiveProperty {\n        Int = 123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new Classes.WithMultiplePrimitivesPrimary()},
                                         "[ WithMultiplePrimitivesPrimary ]",
                                         "[\n    WithMultiplePrimitivesPrimary\n]",
                                         "[\n    WithMultiplePrimitivesPrimary\n]"),

        TestGenerator.TheoryData<object>(new[] {new Classes.WithMultiplePrimitivesField()},
                                         "[ WithMultiplePrimitivesField { Int = 123, Double = 456.123 } ]",
                                         "[\n    WithMultiplePrimitivesField { Int = 123, Double = 456.123 }\n]",
                                         "[\n    WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new Classes.WithMultiplePrimitivesProperty()},
                                         "[ WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 } ]",
                                         "[\n    WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }\n]",
                                         "[\n    WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new Classes.WithMultiplePrimitivesPrimary(), new Classes.WithMultiplePrimitivesPrimary()},
                                         "[ WithMultiplePrimitivesPrimary, WithMultiplePrimitivesPrimary ]",
                                         "[\n    WithMultiplePrimitivesPrimary,\n    WithMultiplePrimitivesPrimary\n]",
                                         "[\n    WithMultiplePrimitivesPrimary,\n    WithMultiplePrimitivesPrimary\n]"),

        TestGenerator.TheoryData<object>(new[] {new Classes.WithMultiplePrimitivesField(), new Classes.WithMultiplePrimitivesField()},
                                         "[ WithMultiplePrimitivesField { Int = 123, Double = 456.123 }, WithMultiplePrimitivesField { Int = 123, Double = 456.123 } ]",
                                         "[\n    WithMultiplePrimitivesField { Int = 123, Double = 456.123 },\n    WithMultiplePrimitivesField { Int = 123, Double = 456.123 }\n]",
                                         "[\n    WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    },\n    WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new Classes.WithMultiplePrimitivesProperty(), new Classes.WithMultiplePrimitivesProperty()},
                                         "[ WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }, WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 } ]",
                                         "[\n    WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 },\n    WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }\n]",
                                         "[\n    WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    },\n    WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new Classes.With1CyclicalField()},
                                         "[ With1CyclicalField { Child = With1CyclicalField (skipped) } ]",
                                         "[\n    With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    }\n]",
                                         "[\n    With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new Classes.With1CyclicalProperty()},
                                         "[ With1CyclicalProperty { Child = With1CyclicalProperty (skipped) } ]",
                                         "[\n    With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    }\n]",
                                         "[\n    With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new Classes.With1CyclicalField(), new Classes.With1CyclicalField()},
                                         "[ With1CyclicalField { Child = With1CyclicalField (skipped) }, With1CyclicalField { Child = With1CyclicalField (skipped) } ]",
                                         "[\n    With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    },\n    With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    }\n]",
                                         "[\n    With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    },\n    With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new Classes.With1CyclicalProperty(), new Classes.With1CyclicalProperty()},
                                         "[ With1CyclicalProperty { Child = With1CyclicalProperty (skipped) }, With1CyclicalProperty { Child = With1CyclicalProperty (skipped) } ]",
                                         "[\n    With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    },\n    With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    }\n]",
                                         "[\n    With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    },\n    With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    }\n]"),
    };
    
    public static TheoryData<object, string, IndentationStyle> EnumerableOfRecordClasses() => new() {
        TestGenerator.TheoryData<object>(Array.Empty<RecordClasses.Empty>(), "[ ]"),

        TestGenerator.TheoryData<object>(new[] {new RecordClasses.Empty()},
                                         "[ Empty ]",
                                         "[\n    Empty\n]",
                                         "[\n    Empty\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordClasses.Empty(), new RecordClasses.Empty()},
                                         "[ Empty, Empty ]",
                                         "[\n    Empty,\n    Empty\n]",
                                         "[\n    Empty,\n    Empty\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordClasses.With1PrimitivePrimary()},
                                         "[ With1PrimitivePrimary { Int = 123 } ]",
                                         "[\n    With1PrimitivePrimary { Int = 123 }\n]",
                                         "[\n    With1PrimitivePrimary {\n        Int = 123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordClasses.With1PrimitiveField()},
                                         "[ With1PrimitiveField { Int = 123 } ]",
                                         "[\n    With1PrimitiveField { Int = 123 }\n]",
                                         "[\n    With1PrimitiveField {\n        Int = 123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordClasses.With1PrimitiveProperty()},
                                         "[ With1PrimitiveProperty { Int = 123 } ]",
                                         "[\n    With1PrimitiveProperty { Int = 123 }\n]",
                                         "[\n    With1PrimitiveProperty {\n        Int = 123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordClasses.With1PrimitivePrimary(), new RecordClasses.With1PrimitivePrimary()},
                                         "[ With1PrimitivePrimary { Int = 123 }, With1PrimitivePrimary { Int = 123 } ]",
                                         "[\n    With1PrimitivePrimary { Int = 123 },\n    With1PrimitivePrimary { Int = 123 }\n]",
                                         "[\n    With1PrimitivePrimary {\n        Int = 123\n    },\n    With1PrimitivePrimary {\n        Int = 123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordClasses.With1PrimitiveField(), new RecordClasses.With1PrimitiveField()},
                                         "[ With1PrimitiveField { Int = 123 }, With1PrimitiveField { Int = 123 } ]",
                                         "[\n    With1PrimitiveField { Int = 123 },\n    With1PrimitiveField { Int = 123 }\n]",
                                         "[\n    With1PrimitiveField {\n        Int = 123\n    },\n    With1PrimitiveField {\n        Int = 123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordClasses.With1PrimitiveProperty(), new RecordClasses.With1PrimitiveProperty()},
                                         "[ With1PrimitiveProperty { Int = 123 }, With1PrimitiveProperty { Int = 123 } ]",
                                         "[\n    With1PrimitiveProperty { Int = 123 },\n    With1PrimitiveProperty { Int = 123 }\n]",
                                         "[\n    With1PrimitiveProperty {\n        Int = 123\n    },\n    With1PrimitiveProperty {\n        Int = 123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordClasses.WithMultiplePrimitivesPrimary()},
                                         "[ WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 } ]",
                                         "[\n    WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 }\n]",
                                         "[\n    WithMultiplePrimitivesPrimary {\n        Int = 123,\n        Double = 456.123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordClasses.WithMultiplePrimitivesField()},
                                         "[ WithMultiplePrimitivesField { Int = 123, Double = 456.123 } ]",
                                         "[\n    WithMultiplePrimitivesField { Int = 123, Double = 456.123 }\n]",
                                         "[\n    WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordClasses.WithMultiplePrimitivesProperty()},
                                         "[ WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 } ]",
                                         "[\n    WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }\n]",
                                         "[\n    WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordClasses.WithMultiplePrimitivesPrimary(), new RecordClasses.WithMultiplePrimitivesPrimary()},
                                         "[ WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 }, WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 } ]",
                                         "[\n    WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 },\n    WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 }\n]",
                                         "[\n    WithMultiplePrimitivesPrimary {\n        Int = 123,\n        Double = 456.123\n    },\n    WithMultiplePrimitivesPrimary {\n        Int = 123,\n        Double = 456.123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordClasses.WithMultiplePrimitivesField(), new RecordClasses.WithMultiplePrimitivesField()},
                                         "[ WithMultiplePrimitivesField { Int = 123, Double = 456.123 }, WithMultiplePrimitivesField { Int = 123, Double = 456.123 } ]",
                                         "[\n    WithMultiplePrimitivesField { Int = 123, Double = 456.123 },\n    WithMultiplePrimitivesField { Int = 123, Double = 456.123 }\n]",
                                         "[\n    WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    },\n    WithMultiplePrimitivesField {\n        Int = 123,\n        Double = 456.123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordClasses.WithMultiplePrimitivesProperty(), new RecordClasses.WithMultiplePrimitivesProperty()},
                                         "[ WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }, WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 } ]",
                                         "[\n    WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 },\n    WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }\n]",
                                         "[\n    WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    },\n    WithMultiplePrimitivesProperty {\n        Int = 123,\n        Double = 456.123\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordClasses.With1CyclicalField()},
                                         "[ With1CyclicalField { Child = With1CyclicalField (skipped) } ]",
                                         "[\n    With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    }\n]",
                                         "[\n    With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordClasses.With1CyclicalProperty()},
                                         "[ With1CyclicalProperty { Child = With1CyclicalProperty (skipped) } ]",
                                         "[\n    With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    }\n]",
                                         "[\n    With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordClasses.With1CyclicalField(), new RecordClasses.With1CyclicalField()},
                                         "[ With1CyclicalField { Child = With1CyclicalField (skipped) }, With1CyclicalField { Child = With1CyclicalField (skipped) } ]",
                                         "[\n    With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    },\n    With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    }\n]",
                                         "[\n    With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    },\n    With1CyclicalField {\n        Child = With1CyclicalField (skipped)\n    }\n]"),

        TestGenerator.TheoryData<object>(new[] {new RecordClasses.With1CyclicalProperty(), new RecordClasses.With1CyclicalProperty()},
                                         "[ With1CyclicalProperty { Child = With1CyclicalProperty (skipped) }, With1CyclicalProperty { Child = With1CyclicalProperty (skipped) } ]",
                                         "[\n    With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    },\n    With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    }\n]",
                                         "[\n    With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    },\n    With1CyclicalProperty {\n        Child = With1CyclicalProperty (skipped)\n    }\n]"),
    };
}
