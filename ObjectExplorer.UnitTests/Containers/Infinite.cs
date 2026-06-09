using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectExplorer.UnitTests.Containers;

public static class Infinite {
    public class InfiniteClass {
        public InfiniteClass Child => new();
    }
}
