using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.Json.Serialization;

namespace ObjectExplorer.UnitTests.Containers;

public static class Complex {
    public struct ComplexStruct {
        public Color Color = Color.AliceBlue;
        public DateTime Established { get; set; } = new DateTime(1999, 10, 30, 4, 2, 21, 123);
        public float Width = 99.99f;
        public int Employees { get; set; } = 999;
        public decimal[][] RoomsPerFloor = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
        public int[,] PeoplePerRoom { get; set; } = { { 10, 9, 8 }, { 7, 6, 5 }, { 3, 2, 1 } };
        public bool Open = false;
        public char Symbol { get; set; } = '@';
        public List<string> Mottos = ["Fail whale"];
        public double Cost { get; set; } = 100980.1;
        public Dictionary<object, object?> Product { get; set; } = new() { { "Name", "ProductName!" }, { "ExpiryDate", new DateTime(2026, 5, 20) }, { "Price", 9.9 }, { "Sizes", null }, { "This", null }, { "Itself", null }, { "Rooms", null } };
        public IEnumerable<object?> Other;
        public List<object> Nested = [];
        public Type MyType = typeof(int);
        [JsonIgnore]
        public bool IgnoreProperty { get; set; } = true;
        [JsonIgnore]
        public bool IgnoreField = true;

        public ComplexStruct() {
            Product["This"] = this;
            Product["Itself"] = Product;
            Product["Rooms"] = RoomsPerFloor;

            Other = [RoomsPerFloor, PeoplePerRoom, Mottos];

            Nested.Add(Nested);
        }
    }

    public record struct ComplexRecordStruct {
        public Color Color = Color.AliceBlue;
        public DateTime Established { get; set; } = new DateTime(1999, 10, 30, 4, 2, 21, 123);
        public float Width = 99.99f;
        public int Employees { get; set; } = 999;
        public decimal[][] RoomsPerFloor = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
        public int[,] PeoplePerRoom { get; set; } = { { 10, 9, 8 }, { 7, 6, 5 }, { 3, 2, 1 } };
        public bool Open = false;
        public char Symbol { get; set; } = '@';
        public List<string> Mottos = ["Fail whale"];
        public double Cost { get; set; } = 100980.1;
        public Dictionary<object, object?> Product { get; set; } = new() { { "Name", "ProductName!" }, { "ExpiryDate", new DateTime(2026, 5, 20) }, { "Price", 9.9 }, { "Sizes", null }, { "This", null }, { "Itself", null }, { "Rooms", null } };
        public IEnumerable<object?> Other;
        public List<object> Nested = [];
        public Type MyType = typeof(int);
        [JsonIgnore]
        public bool IgnoreProperty { get; set; } = true;
        [JsonIgnore]
        public bool IgnoreField = true;

        public ComplexRecordStruct() {
            Product["This"] = this;
            Product["Itself"] = Product;
            Product["Rooms"] = RoomsPerFloor;

            Other = [RoomsPerFloor, PeoplePerRoom, Mottos];

            Nested.Add(Nested);
        }
    }

    public class ComplexClass {
        public Color Color = Color.AliceBlue;
        public DateTime Established { get; set; } = new DateTime(1999, 10, 30, 4, 2, 21, 123);
        public float Width = 99.99f;
        public int Employees { get; set; } = 999;
        public decimal[][] RoomsPerFloor = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
        public int[,] PeoplePerRoom { get; set; } = { { 10, 9, 8 }, { 7, 6, 5 }, { 3, 2, 1 } };
        public bool Open = false;
        public char Symbol { get; set; } = '@';
        public List<string> Mottos = ["Fail whale"];
        public double Cost { get; set; } = 100980.1;
        public Dictionary<object, object?> Product { get; set; } = new() { { "Name", "ProductName!" }, { "ExpiryDate", new DateTime(2026, 5, 20) }, { "Price", 9.9 }, { "Sizes", null }, { "This", null }, { "Itself", null }, { "Rooms", null } };
        public IEnumerable<object?> Other;
        public List<object> Nested = [];
        public Type MyType = typeof(int);
        public ComplexClass This;
        [JsonIgnore]
        public bool IgnoreProperty { get; set; } = true;
        [JsonIgnore]
        public bool IgnoreField = true;

        public ComplexClass() {
            Product["Me"] = this;
            Product["Itself"] = Product;
            Product["Rooms"] = RoomsPerFloor;

            Other = [RoomsPerFloor, PeoplePerRoom, Mottos];

            Nested.Add(Nested);
            
            This = this;
        }
    }

    public record ComplexRecordClass {
        public Color Color = Color.AliceBlue;
        public DateTime Established { get; set; } = new DateTime(1999, 10, 30, 4, 2, 21, 123);
        public float Width = 99.99f;
        public int Employees { get; set; } = 999;
        public decimal[][] RoomsPerFloor = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
        public int[,] PeoplePerRoom { get; set; } = { { 10, 9, 8 }, { 7, 6, 5 }, { 3, 2, 1 } };
        public bool Open = false;
        public char Symbol { get; set; } = '@';
        public List<string> Mottos = ["Fail whale"];
        public double Cost { get; set; } = 100980.1;
        public Dictionary<object, object?> Product { get; set; } = new() { { "Name", "ProductName!" }, { "ExpiryDate", new DateTime(2026, 5, 20) }, { "Price", 9.9 }, { "Sizes", null }, { "This", null }, { "Itself", null }, { "Rooms", null } };
        public IEnumerable<object?> Other;
        public List<object> Nested = [];
        public Type MyType = typeof(int);
        public ComplexRecordClass This;
        [JsonIgnore]
        public bool IgnoreProperty { get; set; } = true;
        [JsonIgnore]
        public bool IgnoreField = true;

        public ComplexRecordClass() {
            Product["This"] = this;
            Product["Itself"] = Product;
            Product["Rooms"] = RoomsPerFloor;

            Other = [RoomsPerFloor, PeoplePerRoom, Mottos];

            Nested.Add(Nested);

            This = this;
        }
    }
}
