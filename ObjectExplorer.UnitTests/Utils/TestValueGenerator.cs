using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectExplorer.UnitTests.Utils;

using Containers;

public static class TestValueGenerator {
    public static Exception GetDivideByZeroException() {
        try {
            var i = 1 / Math.Max(-1, 0);
        } catch(Exception e) {
            return e;
        }

        return new Exception();
    }

    public static Exception GetExceptionWithComplexData() {
        var e = new Exception();

        e.Data.Add("complex", new Complex.ComplexClass());

        return e;
    }
}
