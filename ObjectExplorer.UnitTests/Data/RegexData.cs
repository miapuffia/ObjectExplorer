using ObjectExplorer.PrettyString;
using ObjectExplorer.UnitTests.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectExplorer.UnitTests.Data;

using System.Text.RegularExpressions;

public static class RegexData {
    public static TheoryData<Match, string, IndentationStyle> RegexMatches() => new() {
        TestGenerator.TheoryData(Regex.Match("a9B1cD", @"^(?=(?:.*[A-Z]){2})(?=(?:.*[a-z]){2})(?=.*\d).{5,15}$"),
                                 "Match { Groups = [ Match (skipped) ], Success = True, Name = 0, Captures = [ Match (skipped) ], Index = 0, Length = 6, Value = a9B1cD }",
                                 "Match {\n    Groups = [\n        Match (skipped)\n    ], Success = True, Name = 0,\n    Captures = [\n        Match (skipped)\n    ], Index = 0, Length = 6, Value = a9B1cD\n}",
                                 "Match {\n    Groups = [\n        Match (skipped)\n    ],\n    Success = True,\n    Name = 0,\n    Captures = [\n        Match (skipped)\n    ],\n    Index = 0,\n    Length = 6,\n    Value = a9B1cD\n}"),
    };
}
