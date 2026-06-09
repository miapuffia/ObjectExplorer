using ObjectExplorer.PrettyString;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ObjectExplorer.UnitTests.Data;

using Containers;
using ObjectExplorer.UnitTests.Utils;
using Xunit;

public static class StructData {
    public static TheoryData<ValueType, string, IndentationStyle> Structs() => new() {
        TestGenerator.TheoryData<ValueType>(new Structs.Empty(), "Empty"),

        TestGenerator.TheoryData<ValueType>(new Structs.With1PrimitivePrimary(), "With1PrimitivePrimary"),

        TestGenerator.TheoryData<ValueType>(new Structs.With1PrimitiveField(),
                                            "With1PrimitiveField { Int = 123 }",
                                            "With1PrimitiveField { Int = 123 }",
                                            "With1PrimitiveField {\n    Int = 123\n}"),

        TestGenerator.TheoryData<ValueType>(new Structs.With1PrimitiveProperty(),
                                            "With1PrimitiveProperty { Int = 123 }",
                                            "With1PrimitiveProperty { Int = 123 }",
                                            "With1PrimitiveProperty {\n    Int = 123\n}"),
        
        TestGenerator.TheoryData<ValueType>(new Structs.WithMultiplePrimitivesPrimary(), "WithMultiplePrimitivesPrimary"),

        TestGenerator.TheoryData<ValueType>(new Structs.WithMultiplePrimitivesField(),
                                            "WithMultiplePrimitivesField { Int = 123, Double = 456.123 }",
                                            "WithMultiplePrimitivesField { Int = 123, Double = 456.123 }",
                                            "WithMultiplePrimitivesField {\n    Int = 123,\n    Double = 456.123\n}"),

        TestGenerator.TheoryData<ValueType>(new Structs.WithMultiplePrimitivesProperty(),
                                            "WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }",
                                            "WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }",
                                            "WithMultiplePrimitivesProperty {\n    Int = 123,\n    Double = 456.123\n}"),
    };
    
    public static TheoryData<ValueType, string, IndentationStyle> RecordStructs() => new() {
        TestGenerator.TheoryData<ValueType>(new RecordStructs.Empty(), "Empty"),

        TestGenerator.TheoryData<ValueType>(new RecordStructs.With1PrimitivePrimary(),
                                            "With1PrimitivePrimary { Int = 123 }",
                                            "With1PrimitivePrimary { Int = 123 }",
                                            "With1PrimitivePrimary {\n    Int = 123\n}"),

        TestGenerator.TheoryData<ValueType>(new RecordStructs.With1PrimitiveField(),
                                            "With1PrimitiveField { Int = 123 }",
                                            "With1PrimitiveField { Int = 123 }",
                                            "With1PrimitiveField {\n    Int = 123\n}"),

        TestGenerator.TheoryData<ValueType>(new RecordStructs.With1PrimitiveProperty(),
                                            "With1PrimitiveProperty { Int = 123 }",
                                            "With1PrimitiveProperty { Int = 123 }",
                                            "With1PrimitiveProperty {\n    Int = 123\n}"),

        TestGenerator.TheoryData<ValueType>(new RecordStructs.WithMultiplePrimitivesPrimary(),
                                            "WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 }",
                                            "WithMultiplePrimitivesPrimary { Int = 123, Double = 456.123 }",
                                            "WithMultiplePrimitivesPrimary {\n    Int = 123,\n    Double = 456.123\n}"),

        TestGenerator.TheoryData<ValueType>(new RecordStructs.WithMultiplePrimitivesField(),
                                            "WithMultiplePrimitivesField { Int = 123, Double = 456.123 }",
                                            "WithMultiplePrimitivesField { Int = 123, Double = 456.123 }",
                                            "WithMultiplePrimitivesField {\n    Int = 123,\n    Double = 456.123\n}"),

        TestGenerator.TheoryData<ValueType>(new RecordStructs.WithMultiplePrimitivesProperty(),
                                            "WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }",
                                            "WithMultiplePrimitivesProperty { Int = 123, Double = 456.123 }",
                                            "WithMultiplePrimitivesProperty {\n    Int = 123,\n    Double = 456.123\n}"),
    };
}