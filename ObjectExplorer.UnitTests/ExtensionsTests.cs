using ObjectExplorer.UnitTests.ExtensionsData;

namespace ObjectExplorer.UnitTests;

public class ExtensionsTests {
    [Theory]
    [MemberData(nameof(GetEnumerableTypeData.Data), MemberType = typeof(GetEnumerableTypeData))]
    public void TestGetEnumerableType(Type? testType, Type? expectedType) {
        Assert.Equal(testType, expectedType);
    }
    
    [Theory]
    [MemberData(nameof(GetDictionaryTypesData.Data), MemberType = typeof(GetDictionaryTypesData))]
    public void TestGetDictionaryTypesData((Type, Type)? testTypes, (Type, Type)? expectedTypes) {
        Assert.Equal(testTypes, expectedTypes);
    }
}
