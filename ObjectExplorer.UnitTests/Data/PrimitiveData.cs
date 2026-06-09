using ObjectExplorer.PrettyString;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ObjectExplorer.UnitTests.Data;

using ObjectExplorer.UnitTests.Utils;
using Xunit;

public static class PrimitiveData {
    public static TheoryData<int, string, IndentationStyle> Ints() => new() {
        TestGenerator.TheoryData(0, "0"),
        TestGenerator.TheoryData(-123, "-123"),
        TestGenerator.TheoryData(456, "456"),
        TestGenerator.TheoryData(int.MinValue, "-2147483648"),
        TestGenerator.TheoryData(int.MaxValue, "2147483647"),
    };
    
    public static TheoryData<double, string, IndentationStyle> Doubles() => new() {
        TestGenerator.TheoryData(-123d, "-123"),
        TestGenerator.TheoryData(-0.123, "-0.123"),
        TestGenerator.TheoryData(456d, "456"),
        TestGenerator.TheoryData(789.123, "789.123"),
        TestGenerator.TheoryData(double.MinValue, "-1.7976931348623157E+308"),
        TestGenerator.TheoryData(double.MaxValue, "1.7976931348623157E+308"),
        TestGenerator.TheoryData(double.NegativeInfinity, "-∞"),
        TestGenerator.TheoryData(double.PositiveInfinity, "∞"),
        TestGenerator.TheoryData(double.NaN, "NaN"),
    };
}
