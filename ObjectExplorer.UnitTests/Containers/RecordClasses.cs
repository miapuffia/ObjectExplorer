using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectExplorer.UnitTests.Containers;

public static class RecordClasses {
    public record Empty() { }

    public record With1PrimitivePrimary(int Int = 123) { }

    public record With1PrimitiveField {
        public int Int = 123;
    }

    public record With1PrimitiveProperty {
        public int Int { get; set; } = 123;
    }

    public record WithMultiplePrimitivesPrimary(int Int = 123, double Double = 456.123) { }

    public record WithMultiplePrimitivesField {
        public int Int = 123;
        public double Double = 456.123;
    }

    public record WithMultiplePrimitivesProperty {
        public int Int { get; } = 123;
        public double Double { get; } = 456.123;
    }

    public record With1CyclicalField {
        public With1CyclicalField Child;

        public With1CyclicalField() {
            Child = this;
        }
    }

    public record With1CyclicalProperty {
        public With1CyclicalProperty Child { get; set; }

        public With1CyclicalProperty() {
            Child = this;
        }
    }
}