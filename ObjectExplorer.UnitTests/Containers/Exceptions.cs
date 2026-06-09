using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectExplorer.UnitTests.Containers;

using System.Text.Json.Serialization;

public static class Exceptions {
    public class ExceptionForCoverage : Exception {
        [JsonIgnore]
        public bool IgnoreProperty { get; set; } = true;
        [JsonIgnore]
        public bool IgnoreField = true;

        public string TestField = "YES";
    }
}
