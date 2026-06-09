namespace ObjectExplorer.UnitTests.Utils;

using PrettyString;

public static class TestHelper {
    public static void Equals(object testObject, string expected, IndentationStyle indentation) {
        var pretty = PrettyString.Stringify(testObject, indentation);

        //Don't do Assert.Equals directly do we can print the entire expected output
        if(pretty != expected) {
            Assert.Fail(pretty);
        }
    }
    
    public static void StartsWith(object testObject, string startsWith, IndentationStyle indentation) {
        var pretty = PrettyString.Stringify(testObject, indentation);

        //Don't do Assert.StartsWith directly do we can print the entire expected output
        if(!pretty.StartsWith(startsWith)) {
            Assert.Fail(pretty);
        }
    }
}
