using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ObjectExplorer.UnitTests.Containers;

public static class RecordStructs {
    public record struct Empty { }
    
    //Make new() use primary constructor instead of default()
    [method:OverloadResolutionPriority(1)]
    public record struct With1PrimitivePrimary(int Int = 123) { }

    public record struct With1PrimitiveField() {
        public int Int = 123;
    }

    public record struct With1PrimitiveProperty() {
        public int Int { get; } = 123;
    }
    
    //Make new() use primary constructor instead of default()
    [method:OverloadResolutionPriority(1)]
    public record struct WithMultiplePrimitivesPrimary(int Int = 123, double Double = 456.123) { }

    public record struct WithMultiplePrimitivesField() {
        public int Int = 123;
        public double Double = 456.123;
    }

    public record struct WithMultiplePrimitivesProperty() {
        public int Int { get; } = 123;
        public double Double { get; } = 456.123;
    }
}
