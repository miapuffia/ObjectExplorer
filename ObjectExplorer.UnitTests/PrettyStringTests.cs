namespace ObjectExplorer.UnitTests;

using Data;
using Xunit;
using PrettyString;
using ObjectExplorer.UnitTests.CombinedData;
using ObjectExplorer.UnitTests.Containers;
using ObjectExplorer.UnitTests.Utils;

public class PrettyStringTests {
    [Theory]
    [ClassData(typeof(NullData))]
    public void TestNull(object testObject, string expected, IndentationStyle indentation) {
        TestHelper.Equals(testObject, expected, indentation);
    }
    
    [Theory]
    [MemberData(nameof(PrimitiveData.Ints), MemberType = typeof(PrimitiveData))]
    [MemberData(nameof(PrimitiveData.Doubles), MemberType = typeof(PrimitiveData))]
    public void TestPrimitives(object testObject, string expected, IndentationStyle indentation) {
        TestHelper.Equals(testObject, expected, indentation);
    }

    [Theory]
    [ClassData(typeof(StringData))]
    public void TestString(object testObject, string expected, IndentationStyle indentation) {
        TestHelper.Equals(testObject, expected, indentation);
    }

    [Theory]
    [ClassData(typeof(EnumData))]
    public void TestEnums(object testObject, string expected, IndentationStyle indentation) {
        TestHelper.Equals(testObject, expected, indentation);
    }

    [Theory]
    [MemberData(nameof(StructData.Structs), MemberType = typeof(StructData))]
    [MemberData(nameof(StructData.RecordStructs), MemberType = typeof(StructData))]
    public void TestStruct(object testObject, string expected, IndentationStyle indentation) {
        TestHelper.Equals(testObject, expected, indentation);
    }

    [Theory]
    [MemberData(nameof(ClassData.Classes), MemberType = typeof(ClassData))]
    [MemberData(nameof(ClassData.RecordClasses), MemberType = typeof(ClassData))]
    public void TestClass(object testObject, string expected, IndentationStyle indentation) {
        TestHelper.Equals(testObject, expected, indentation);
    }

    [Theory]
    [ClassData(typeof(EnumerableData))]
    public void TestEnumerable(object testObject, string expected, IndentationStyle indentation) {
        TestHelper.Equals(testObject, expected, indentation);
    }

    [Theory]
    [MemberData(nameof(StructAndEnumerableData.EnumerableOfStructs), MemberType = typeof(StructAndEnumerableData))]
    [MemberData(nameof(StructAndEnumerableData.EnumerableOfRecordStructs), MemberType = typeof(StructAndEnumerableData))]
    public void TestEnumerableOfStructs(object testObject, string expected, IndentationStyle indentation) {
        TestHelper.Equals(testObject, expected, indentation);
    }

    [Theory]
    [MemberData(nameof(ClassAndEnumerableData.EnumerableOfClasses), MemberType = typeof(ClassAndEnumerableData))]
    [MemberData(nameof(ClassAndEnumerableData.EnumerableOfRecordClasses), MemberType = typeof(ClassAndEnumerableData))]
    public void TestEnumerableOfClasses(object testObject, string expected, IndentationStyle indentation) {
        TestHelper.Equals(testObject, expected, indentation);
    }

    [Theory]
    [ClassData(typeof(DictionaryData))]
    public void TestDictionary(object testObject, string expected, IndentationStyle indentation) {
        TestHelper.Equals(testObject, expected, indentation);
    }

    [Theory]
    [MemberData(nameof(StructAndDictionaryData.DictionaryOfStructs), MemberType = typeof(StructAndDictionaryData))]
    [MemberData(nameof(StructAndDictionaryData.DictionaryOfRecordStructs), MemberType = typeof(StructAndDictionaryData))]
    public void TestDictionaryOfStructs(object testObject, string expected, IndentationStyle indentation) {
        TestHelper.Equals(testObject, expected, indentation);
    }

    [Theory]
    [MemberData(nameof(ClassAndDictionaryData.DictionaryOfClasses), MemberType = typeof(ClassAndDictionaryData))]
    [MemberData(nameof(ClassAndDictionaryData.DictionaryOfRecordClasses), MemberType = typeof(ClassAndDictionaryData))]
    public void TestDictionaryOfClasses(object testObject, string expected, IndentationStyle indentation) {
        TestHelper.Equals(testObject, expected, indentation);
    }

    [Theory]
    [MemberData(nameof(ComplexData.Classes), MemberType = typeof(ComplexData))]
    [MemberData(nameof(ComplexData.RecordClasses), MemberType = typeof(ComplexData))]
    [MemberData(nameof(ComplexData.Structs), MemberType = typeof(ComplexData))]
    [MemberData(nameof(ComplexData.RecordStructs), MemberType = typeof(ComplexData))]
    public void TestComplex(object testObject, string expected, IndentationStyle indentation) {
        TestHelper.Equals(testObject, expected, indentation);
    }

    [Theory]
    [MemberData(nameof(ExceptionData.Exceptions), MemberType = typeof(ExceptionData))]
    public void TestExceptions(object testObject, string expected, IndentationStyle indentation) {
        TestHelper.Equals(testObject, expected, indentation);
    }

    [Theory]
    [MemberData(nameof(ExceptionData.ExceptionsStartsWith), MemberType = typeof(ExceptionData))]
    public void TestExceptionsStartsWith(object testObject, string expected, IndentationStyle indentation) {
        TestHelper.StartsWith(testObject, expected, indentation);
    }

    [Theory]
    [MemberData(nameof(InfiniteData.Data), MemberType = typeof(InfiniteData))]
    public void TestInfinite(object testObject, string expected, IndentationStyle indentation) {
        TestHelper.StartsWith(testObject, expected, indentation);
    }

    [Theory]
    [MemberData(nameof(RegexData.RegexMatches), MemberType = typeof(RegexData))]
    public void TestRegex(object testObject, string expected, IndentationStyle indentation) {
        TestHelper.Equals(testObject, expected, indentation);
    }
}
