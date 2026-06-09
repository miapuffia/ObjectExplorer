using ObjectExplorer.PrettyString;
using ObjectExplorer.UnitTests.Containers;
using ObjectExplorer.UnitTests.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectExplorer.UnitTests.Data;

public static class ClassData {
    public static TheoryData<object, string, IndentationStyle> Classes() => new() {
        TestGenerator.TheoryData<object>(new Classes.Empty(), "Empty"),

        TestGenerator.TheoryData<object>(new Classes.With1PrimitivePrimary(), "With1PrimitivePrimary"),

        TestGenerator.TheoryData<object>(new Classes.With1PrimitiveField(),
                                         "With1PrimitiveField { Int = 123 }",
                                         "With1PrimitiveField { Int = 123 }",
                                         "With1PrimitiveField {\n    Int = 123\n}"),

        TestGenerator.TheoryData<object>(new Classes.With1PrimitiveProperty(),
                                         "With1PrimitiveProperty { Int = 123 }",
                                         "With1PrimitiveProperty { Int = 123 }",
                                         "With1PrimitiveProperty {\n    Int = 123\n}"),
        
        TestGenerator.TheoryData<object>(new Classes.WithMultiplePrimitivesPrimary(), "WithMultiplePrimitivesPrimary"),

        TestGenerator.TheoryData<object>(new Classes.WithMultiplePrimitivesField(),
                                         "WithMultiplePrimitivesField { Int = 123, Double = 456.123 }",
                                         "WithMultiplePrimitivesField { Int = 123, Double = 456.123 }",
                                         "WithMultiplePrimitivesField {\n    Int = 123,\n    Double = 456.123\n}"),

        TestGenerator.TheoryData<object>(new Classes.WithMultiplePrimitivesProperty(),
                                         "WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }",
                                         "WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }",
                                         "WithMultiplePrimitivesProperty {\n    Int = 123,\n    Double = 456.123\n}"),

        TestGenerator.TheoryData<object>(new Classes.With1CyclicalField(),
                                         "With1CyclicalField { Child = With1CyclicalField (skipped) }",
                                         "With1CyclicalField {\n    Child = With1CyclicalField (skipped)\n}",
                                         "With1CyclicalField {\n    Child = With1CyclicalField (skipped)\n}"),

        TestGenerator.TheoryData<object>(new Classes.With1CyclicalProperty(),
                                         "With1CyclicalProperty { Child = With1CyclicalProperty (skipped) }",
                                         "With1CyclicalProperty {\n    Child = With1CyclicalProperty (skipped)\n}",
                                         "With1CyclicalProperty {\n    Child = With1CyclicalProperty (skipped)\n}"),
    };
    
    public static TheoryData<object, string, IndentationStyle> RecordClasses() => new() {
        TestGenerator.TheoryData<object>(new RecordClasses.Empty(), "Empty"),

        TestGenerator.TheoryData<object>(new RecordClasses.With1PrimitivePrimary(),
                                         "With1PrimitivePrimary { Int = 123 }",
                                         "With1PrimitivePrimary { Int = 123 }",
                                         "With1PrimitivePrimary {\n    Int = 123\n}"),

        TestGenerator.TheoryData<object>(new RecordClasses.With1PrimitiveField(),
                                         "With1PrimitiveField { Int = 123 }",
                                         "With1PrimitiveField { Int = 123 }",
                                         "With1PrimitiveField {\n    Int = 123\n}"),

        TestGenerator.TheoryData<object>(new RecordClasses.With1PrimitiveProperty(),
                                         "With1PrimitiveProperty { Int = 123 }",
                                         "With1PrimitiveProperty { Int = 123 }",
                                         "With1PrimitiveProperty {\n    Int = 123\n}"),

        TestGenerator.TheoryData<object>(new RecordClasses.WithMultiplePrimitivesPrimary(),
                                         "WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 }",
                                         "WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 }",
                                         "WithMultiplePrimitivesPrimary {\n    Int = 123,\n    Double = 456.123\n}"),

        TestGenerator.TheoryData<object>(new RecordClasses.WithMultiplePrimitivesField(),
                                         "WithMultiplePrimitivesField { Int = 123, Double = 456.123 }",
                                         "WithMultiplePrimitivesField { Int = 123, Double = 456.123 }",
                                         "WithMultiplePrimitivesField {\n    Int = 123,\n    Double = 456.123\n}"),

        TestGenerator.TheoryData<object>(new RecordClasses.WithMultiplePrimitivesProperty(),
                                         "WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }",
                                         "WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }",
                                         "WithMultiplePrimitivesProperty {\n    Int = 123,\n    Double = 456.123\n}"),

        TestGenerator.TheoryData<object>(new RecordClasses.With1CyclicalField(),
                                         "With1CyclicalField { Child = With1CyclicalField (skipped) }",
                                         "With1CyclicalField {\n    Child = With1CyclicalField (skipped)\n}",
                                         "With1CyclicalField {\n    Child = With1CyclicalField (skipped)\n}"),

        TestGenerator.TheoryData<object>(new RecordClasses.With1CyclicalProperty(),
                                         "With1CyclicalProperty { Child = With1CyclicalProperty (skipped) }",
                                         "With1CyclicalProperty {\n    Child = With1CyclicalProperty (skipped)\n}",
                                         "With1CyclicalProperty {\n    Child = With1CyclicalProperty (skipped)\n}"),
    };
}
