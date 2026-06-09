using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectExplorer.UnitTests.Containers;

using System.Runtime.CompilerServices;

public static class Structs {
    public struct Empty { }

    public struct With1PrimitivePrimary(int Int = 123) { }

    public struct With1PrimitiveField() {
        public int Int = 123;
    }

    public struct With1PrimitiveProperty() {
        public int Int { get; } = 123;
    }

    public struct WithMultiplePrimitivesPrimary(int Int = 123, double Double = 456.123) { }

    public struct WithMultiplePrimitivesField() {
        public int Int = 123;
        public double Double = 456.123;
    }

    public struct WithMultiplePrimitivesProperty() {
        public int Int { get; } = 123;
        public double Double { get; } = 456.123;
    }
}
