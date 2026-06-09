using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectExplorer.UnitTests.Containers;

public static class Classes {
    public class Empty() { }

    public class With1PrimitivePrimary(int Int = 123) { }

    public class With1PrimitiveField {
        public int Int = 123;
    }

    public class With1PrimitiveProperty {
        public int Int { get; set; } = 123;
    }

    public class WithMultiplePrimitivesPrimary(int Int = 123, double Double = 456.123) { }

    public class WithMultiplePrimitivesField {
        public int Int = 123;
        public double Double = 456.123;
    }

    public class WithMultiplePrimitivesProperty {
        public int Int { get; } = 123;
        public double Double { get; } = 456.123;
    }

    public class With1CyclicalField {
        public With1CyclicalField Child;

        public With1CyclicalField() {
            Child = this;
        }
    }

    public class With1CyclicalProperty {
        public With1CyclicalProperty Child { get; set; }

        public With1CyclicalProperty() {
            Child = this;
        }
    }
}
