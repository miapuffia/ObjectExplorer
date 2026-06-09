namespace ObjectExplorer.UnitTests.Data;

using Containers;
using PrettyString;
using Utils;

//Note that this file must be saved with LF line endings for tests to pass!
public static class ComplexData {
    public static TheoryData<object, string, IndentationStyle> Classes() => new() {
        TestGenerator.TheoryData<object>(new Complex.ComplexClass(),
                                         "ComplexClass { Established = 10/30/1999 04:02:21, Employees = 999, PeoplePerRoom = [ 10, 9, 8, 7, 6, 5, 3, 2, 1 ], Symbol = @, Cost = 100980.1, Product = { [ Name ] = ProductName!, [ ExpiryDate ] = 5/20/2026 00:00:00, [ Price ] = 9.9, [ Sizes ] = null, [ This ] = null, [ Itself ] = Dictionary`2 (skipped), [ Rooms ] = [ [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ] ], [ Me ] = ComplexClass (skipped) }, Color = Color { R = 240, G = 248, B = 255, A = 255, IsKnownColor = True, IsEmpty = False, IsNamedColor = True, IsSystemColor = False, Name = AliceBlue }, Width = 99.99, RoomsPerFloor = [ [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ] ], Open = False, Mottos = [ Fail whale ], Other = [ [ [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ] ], [ 10, 9, 8, 7, 6, 5, 3, 2, 1 ], [ Fail whale ] ], Nested = [ List`1 (skipped) ], MyType = Type (RuntimeType), This = ComplexClass (skipped) }",
                                         """
                                         ComplexClass {
                                             Established = 10/30/1999 04:02:21, Employees = 999,
                                             PeoplePerRoom = [ 10, 9, 8, 7, 6, 5, 3, 2, 1 ], Symbol = @, Cost = 100980.1,
                                             Product = { [ Name ] = ProductName!,
                                                 [ ExpiryDate ] = 5/20/2026 00:00:00, [ Price ] = 9.9, [ Sizes ] = null, [ This ] = null,
                                                 [ Itself ] = Dictionary`2 (skipped),
                                                 [ Rooms ] = [
                                                     [
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 }
                                                     ],
                                                     [
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 }
                                                     ],
                                                     [
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 }
                                                     ]
                                                 ],
                                                 [ Me ] = ComplexClass (skipped)
                                             },
                                             Color = Color { R = 240, G = 248, B = 255, A = 255, IsKnownColor = True, IsEmpty = False, IsNamedColor = True, IsSystemColor = False, Name = AliceBlue }, Width = 99.99,
                                             RoomsPerFloor = [
                                                 [
                                                     Decimal { Scale = 0 },
                                                     Decimal { Scale = 0 },
                                                     Decimal { Scale = 0 }
                                                 ],
                                                 [
                                                     Decimal { Scale = 0 },
                                                     Decimal { Scale = 0 },
                                                     Decimal { Scale = 0 }
                                                 ],
                                                 [
                                                     Decimal { Scale = 0 },
                                                     Decimal { Scale = 0 },
                                                     Decimal { Scale = 0 }
                                                 ]
                                             ], Open = False,
                                             Mottos = [ Fail whale ],
                                             Other = [
                                                 [
                                                     [
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 }
                                                     ],
                                                     [
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 }
                                                     ],
                                                     [
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 }
                                                     ]
                                                 ],
                                                 [ 10, 9, 8, 7, 6, 5, 3, 2, 1 ],
                                                 [ Fail whale ]
                                             ],
                                             Nested = [
                                                 List`1 (skipped)
                                             ],
                                             MyType = Type (RuntimeType),
                                             This = ComplexClass (skipped)
                                         }
                                         """,
                                         """
                                         ComplexClass {
                                             Established = 10/30/1999 04:02:21,
                                             Employees = 999,
                                             PeoplePerRoom = [
                                                 10,
                                                 9,
                                                 8,
                                                 7,
                                                 6,
                                                 5,
                                                 3,
                                                 2,
                                                 1
                                             ],
                                             Symbol = @,
                                             Cost = 100980.1,
                                             Product = {
                                                 [ Name ] = ProductName!,
                                                 [ ExpiryDate ] = 5/20/2026 00:00:00,
                                                 [ Price ] = 9.9,
                                                 [ Sizes ] = null,
                                                 [ This ] = null,
                                                 [ Itself ] = Dictionary`2 (skipped),
                                                 [ Rooms ] = [
                                                     [
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         }
                                                     ],
                                                     [
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         }
                                                     ],
                                                     [
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         }
                                                     ]
                                                 ],
                                                 [ Me ] = ComplexClass (skipped)
                                             },
                                             Color = Color {
                                                 R = 240,
                                                 G = 248,
                                                 B = 255,
                                                 A = 255,
                                                 IsKnownColor = True,
                                                 IsEmpty = False,
                                                 IsNamedColor = True,
                                                 IsSystemColor = False,
                                                 Name = AliceBlue
                                             },
                                             Width = 99.99,
                                             RoomsPerFloor = [
                                                 [
                                                     Decimal {
                                                         Scale = 0
                                                     },
                                                     Decimal {
                                                         Scale = 0
                                                     },
                                                     Decimal {
                                                         Scale = 0
                                                     }
                                                 ],
                                                 [
                                                     Decimal {
                                                         Scale = 0
                                                     },
                                                     Decimal {
                                                         Scale = 0
                                                     },
                                                     Decimal {
                                                         Scale = 0
                                                     }
                                                 ],
                                                 [
                                                     Decimal {
                                                         Scale = 0
                                                     },
                                                     Decimal {
                                                         Scale = 0
                                                     },
                                                     Decimal {
                                                         Scale = 0
                                                     }
                                                 ]
                                             ],
                                             Open = False,
                                             Mottos = [
                                                 Fail whale
                                             ],
                                             Other = [
                                                 [
                                                     [
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         }
                                                     ],
                                                     [
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         }
                                                     ],
                                                     [
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         }
                                                     ]
                                                 ],
                                                 [
                                                     10,
                                                     9,
                                                     8,
                                                     7,
                                                     6,
                                                     5,
                                                     3,
                                                     2,
                                                     1
                                                 ],
                                                 [
                                                     Fail whale
                                                 ]
                                             ],
                                             Nested = [
                                                 List`1 (skipped)
                                             ],
                                             MyType = Type (RuntimeType),
                                             This = ComplexClass (skipped)
                                         }
                                         """),
    };
    
    public static TheoryData<object, string, IndentationStyle> RecordClasses() => new() {
        TestGenerator.TheoryData<object>(new Complex.ComplexRecordClass(),
                                         "ComplexRecordClass { Established = 10/30/1999 04:02:21, Employees = 999, PeoplePerRoom = [ 10, 9, 8, 7, 6, 5, 3, 2, 1 ], Symbol = @, Cost = 100980.1, Product = { [ Name ] = ProductName!, [ ExpiryDate ] = 5/20/2026 00:00:00, [ Price ] = 9.9, [ Sizes ] = null, [ This ] = ComplexRecordClass (skipped), [ Itself ] = Dictionary`2 (skipped), [ Rooms ] = [ [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ] ] }, Color = Color { R = 240, G = 248, B = 255, A = 255, IsKnownColor = True, IsEmpty = False, IsNamedColor = True, IsSystemColor = False, Name = AliceBlue }, Width = 99.99, RoomsPerFloor = [ [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ] ], Open = False, Mottos = [ Fail whale ], Other = [ [ [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ] ], [ 10, 9, 8, 7, 6, 5, 3, 2, 1 ], [ Fail whale ] ], Nested = [ List`1 (skipped) ], MyType = Type (RuntimeType), This = ComplexRecordClass (skipped) }",
                                         """
                                         ComplexRecordClass {
                                             Established = 10/30/1999 04:02:21, Employees = 999,
                                             PeoplePerRoom = [ 10, 9, 8, 7, 6, 5, 3, 2, 1 ], Symbol = @, Cost = 100980.1,
                                             Product = { [ Name ] = ProductName!,
                                                 [ ExpiryDate ] = 5/20/2026 00:00:00, [ Price ] = 9.9, [ Sizes ] = null,
                                                 [ This ] = ComplexRecordClass (skipped),
                                                 [ Itself ] = Dictionary`2 (skipped),
                                                 [ Rooms ] = [
                                                     [
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 }
                                                     ],
                                                     [
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 }
                                                     ],
                                                     [
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 }
                                                     ]
                                                 ]
                                             },
                                             Color = Color { R = 240, G = 248, B = 255, A = 255, IsKnownColor = True, IsEmpty = False, IsNamedColor = True, IsSystemColor = False, Name = AliceBlue }, Width = 99.99,
                                             RoomsPerFloor = [
                                                 [
                                                     Decimal { Scale = 0 },
                                                     Decimal { Scale = 0 },
                                                     Decimal { Scale = 0 }
                                                 ],
                                                 [
                                                     Decimal { Scale = 0 },
                                                     Decimal { Scale = 0 },
                                                     Decimal { Scale = 0 }
                                                 ],
                                                 [
                                                     Decimal { Scale = 0 },
                                                     Decimal { Scale = 0 },
                                                     Decimal { Scale = 0 }
                                                 ]
                                             ], Open = False,
                                             Mottos = [ Fail whale ],
                                             Other = [
                                                 [
                                                     [
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 }
                                                     ],
                                                     [
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 }
                                                     ],
                                                     [
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 },
                                                         Decimal { Scale = 0 }
                                                     ]
                                                 ],
                                                 [ 10, 9, 8, 7, 6, 5, 3, 2, 1 ],
                                                 [ Fail whale ]
                                             ],
                                             Nested = [
                                                 List`1 (skipped)
                                             ],
                                             MyType = Type (RuntimeType),
                                             This = ComplexRecordClass (skipped)
                                         }
                                         """,
                                         """
                                         ComplexRecordClass {
                                             Established = 10/30/1999 04:02:21,
                                             Employees = 999,
                                             PeoplePerRoom = [
                                                 10,
                                                 9,
                                                 8,
                                                 7,
                                                 6,
                                                 5,
                                                 3,
                                                 2,
                                                 1
                                             ],
                                             Symbol = @,
                                             Cost = 100980.1,
                                             Product = {
                                                 [ Name ] = ProductName!,
                                                 [ ExpiryDate ] = 5/20/2026 00:00:00,
                                                 [ Price ] = 9.9,
                                                 [ Sizes ] = null,
                                                 [ This ] = ComplexRecordClass (skipped),
                                                 [ Itself ] = Dictionary`2 (skipped),
                                                 [ Rooms ] = [
                                                     [
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         }
                                                     ],
                                                     [
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         }
                                                     ],
                                                     [
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         }
                                                     ]
                                                 ]
                                             },
                                             Color = Color {
                                                 R = 240,
                                                 G = 248,
                                                 B = 255,
                                                 A = 255,
                                                 IsKnownColor = True,
                                                 IsEmpty = False,
                                                 IsNamedColor = True,
                                                 IsSystemColor = False,
                                                 Name = AliceBlue
                                             },
                                             Width = 99.99,
                                             RoomsPerFloor = [
                                                 [
                                                     Decimal {
                                                         Scale = 0
                                                     },
                                                     Decimal {
                                                         Scale = 0
                                                     },
                                                     Decimal {
                                                         Scale = 0
                                                     }
                                                 ],
                                                 [
                                                     Decimal {
                                                         Scale = 0
                                                     },
                                                     Decimal {
                                                         Scale = 0
                                                     },
                                                     Decimal {
                                                         Scale = 0
                                                     }
                                                 ],
                                                 [
                                                     Decimal {
                                                         Scale = 0
                                                     },
                                                     Decimal {
                                                         Scale = 0
                                                     },
                                                     Decimal {
                                                         Scale = 0
                                                     }
                                                 ]
                                             ],
                                             Open = False,
                                             Mottos = [
                                                 Fail whale
                                             ],
                                             Other = [
                                                 [
                                                     [
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         }
                                                     ],
                                                     [
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         }
                                                     ],
                                                     [
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         },
                                                         Decimal {
                                                             Scale = 0
                                                         }
                                                     ]
                                                 ],
                                                 [
                                                     10,
                                                     9,
                                                     8,
                                                     7,
                                                     6,
                                                     5,
                                                     3,
                                                     2,
                                                     1
                                                 ],
                                                 [
                                                     Fail whale
                                                 ]
                                             ],
                                             Nested = [
                                                 List`1 (skipped)
                                             ],
                                             MyType = Type (RuntimeType),
                                             This = ComplexRecordClass (skipped)
                                         }
                                         """),
    };

    public static TheoryData<ValueType, string, IndentationStyle> Structs() => new() {
        TestGenerator.TheoryData<ValueType>(new Complex.ComplexStruct(),
                                            "ComplexStruct { Established = 10/30/1999 04:02:21, Employees = 999, PeoplePerRoom = [ 10, 9, 8, 7, 6, 5, 3, 2, 1 ], Symbol = @, Cost = 100980.1, Product = { [ Name ] = ProductName!, [ ExpiryDate ] = 5/20/2026 00:00:00, [ Price ] = 9.9, [ Sizes ] = null, [ This ] = ComplexStruct { Established = 10/30/1999 04:02:21, Employees = 999, PeoplePerRoom = [ 10, 9, 8, 7, 6, 5, 3, 2, 1 ], Symbol = @, Cost = 100980.1, Product = Dictionary`2 (skipped), Color = Color { R = 240, G = 248, B = 255, A = 255, IsKnownColor = True, IsEmpty = False, IsNamedColor = True, IsSystemColor = False, Name = AliceBlue }, Width = 99.99, RoomsPerFloor = [ [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ] ], Open = False, Mottos = [ Fail whale ], Other = null, Nested = [ List`1 (skipped) ], MyType = Type (RuntimeType) }, [ Itself ] = Dictionary`2 (skipped), [ Rooms ] = [ [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ] ] }, Color = Color { R = 240, G = 248, B = 255, A = 255, IsKnownColor = True, IsEmpty = False, IsNamedColor = True, IsSystemColor = False, Name = AliceBlue }, Width = 99.99, RoomsPerFloor = [ [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ] ], Open = False, Mottos = [ Fail whale ], Other = [ [ [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ] ], [ 10, 9, 8, 7, 6, 5, 3, 2, 1 ], [ Fail whale ] ], Nested = [ List`1 (skipped) ], MyType = Type (RuntimeType) }",
                                            """
                                            ComplexStruct {
                                                Established = 10/30/1999 04:02:21, Employees = 999,
                                                PeoplePerRoom = [ 10, 9, 8, 7, 6, 5, 3, 2, 1 ], Symbol = @, Cost = 100980.1,
                                                Product = { [ Name ] = ProductName!,
                                                    [ ExpiryDate ] = 5/20/2026 00:00:00, [ Price ] = 9.9, [ Sizes ] = null,
                                                    [ This ] = ComplexStruct {
                                                        Established = 10/30/1999 04:02:21, Employees = 999,
                                                        PeoplePerRoom = [ 10, 9, 8, 7, 6, 5, 3, 2, 1 ], Symbol = @, Cost = 100980.1,
                                                        Product = Dictionary`2 (skipped),
                                                        Color = Color { R = 240, G = 248, B = 255, A = 255, IsKnownColor = True, IsEmpty = False, IsNamedColor = True, IsSystemColor = False, Name = AliceBlue }, Width = 99.99,
                                                        RoomsPerFloor = [
                                                            [
                                                                Decimal { Scale = 0 },
                                                                Decimal { Scale = 0 },
                                                                Decimal { Scale = 0 }
                                                            ],
                                                            [
                                                                Decimal { Scale = 0 },
                                                                Decimal { Scale = 0 },
                                                                Decimal { Scale = 0 }
                                                            ],
                                                            [
                                                                Decimal { Scale = 0 },
                                                                Decimal { Scale = 0 },
                                                                Decimal { Scale = 0 }
                                                            ]
                                                        ], Open = False,
                                                        Mottos = [ Fail whale ], Other = null,
                                                        Nested = [
                                                            List`1 (skipped)
                                                        ],
                                                        MyType = Type (RuntimeType)
                                                    },
                                                    [ Itself ] = Dictionary`2 (skipped),
                                                    [ Rooms ] = [
                                                        [
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 }
                                                        ],
                                                        [
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 }
                                                        ],
                                                        [
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 }
                                                        ]
                                                    ]
                                                },
                                                Color = Color { R = 240, G = 248, B = 255, A = 255, IsKnownColor = True, IsEmpty = False, IsNamedColor = True, IsSystemColor = False, Name = AliceBlue }, Width = 99.99,
                                                RoomsPerFloor = [
                                                    [
                                                        Decimal { Scale = 0 },
                                                        Decimal { Scale = 0 },
                                                        Decimal { Scale = 0 }
                                                    ],
                                                    [
                                                        Decimal { Scale = 0 },
                                                        Decimal { Scale = 0 },
                                                        Decimal { Scale = 0 }
                                                    ],
                                                    [
                                                        Decimal { Scale = 0 },
                                                        Decimal { Scale = 0 },
                                                        Decimal { Scale = 0 }
                                                    ]
                                                ], Open = False,
                                                Mottos = [ Fail whale ],
                                                Other = [
                                                    [
                                                        [
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 }
                                                        ],
                                                        [
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 }
                                                        ],
                                                        [
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 }
                                                        ]
                                                    ],
                                                    [ 10, 9, 8, 7, 6, 5, 3, 2, 1 ],
                                                    [ Fail whale ]
                                                ],
                                                Nested = [
                                                    List`1 (skipped)
                                                ],
                                                MyType = Type (RuntimeType)
                                            }
                                            """,
                                            """
                                            ComplexStruct {
                                                Established = 10/30/1999 04:02:21,
                                                Employees = 999,
                                                PeoplePerRoom = [
                                                    10,
                                                    9,
                                                    8,
                                                    7,
                                                    6,
                                                    5,
                                                    3,
                                                    2,
                                                    1
                                                ],
                                                Symbol = @,
                                                Cost = 100980.1,
                                                Product = {
                                                    [ Name ] = ProductName!,
                                                    [ ExpiryDate ] = 5/20/2026 00:00:00,
                                                    [ Price ] = 9.9,
                                                    [ Sizes ] = null,
                                                    [ This ] = ComplexStruct {
                                                        Established = 10/30/1999 04:02:21,
                                                        Employees = 999,
                                                        PeoplePerRoom = [
                                                            10,
                                                            9,
                                                            8,
                                                            7,
                                                            6,
                                                            5,
                                                            3,
                                                            2,
                                                            1
                                                        ],
                                                        Symbol = @,
                                                        Cost = 100980.1,
                                                        Product = Dictionary`2 (skipped),
                                                        Color = Color {
                                                            R = 240,
                                                            G = 248,
                                                            B = 255,
                                                            A = 255,
                                                            IsKnownColor = True,
                                                            IsEmpty = False,
                                                            IsNamedColor = True,
                                                            IsSystemColor = False,
                                                            Name = AliceBlue
                                                        },
                                                        Width = 99.99,
                                                        RoomsPerFloor = [
                                                            [
                                                                Decimal {
                                                                    Scale = 0
                                                                },
                                                                Decimal {
                                                                    Scale = 0
                                                                },
                                                                Decimal {
                                                                    Scale = 0
                                                                }
                                                            ],
                                                            [
                                                                Decimal {
                                                                    Scale = 0
                                                                },
                                                                Decimal {
                                                                    Scale = 0
                                                                },
                                                                Decimal {
                                                                    Scale = 0
                                                                }
                                                            ],
                                                            [
                                                                Decimal {
                                                                    Scale = 0
                                                                },
                                                                Decimal {
                                                                    Scale = 0
                                                                },
                                                                Decimal {
                                                                    Scale = 0
                                                                }
                                                            ]
                                                        ],
                                                        Open = False,
                                                        Mottos = [
                                                            Fail whale
                                                        ],
                                                        Other = null,
                                                        Nested = [
                                                            List`1 (skipped)
                                                        ],
                                                        MyType = Type (RuntimeType)
                                                    },
                                                    [ Itself ] = Dictionary`2 (skipped),
                                                    [ Rooms ] = [
                                                        [
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            }
                                                        ],
                                                        [
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            }
                                                        ],
                                                        [
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            }
                                                        ]
                                                    ]
                                                },
                                                Color = Color {
                                                    R = 240,
                                                    G = 248,
                                                    B = 255,
                                                    A = 255,
                                                    IsKnownColor = True,
                                                    IsEmpty = False,
                                                    IsNamedColor = True,
                                                    IsSystemColor = False,
                                                    Name = AliceBlue
                                                },
                                                Width = 99.99,
                                                RoomsPerFloor = [
                                                    [
                                                        Decimal {
                                                            Scale = 0
                                                        },
                                                        Decimal {
                                                            Scale = 0
                                                        },
                                                        Decimal {
                                                            Scale = 0
                                                        }
                                                    ],
                                                    [
                                                        Decimal {
                                                            Scale = 0
                                                        },
                                                        Decimal {
                                                            Scale = 0
                                                        },
                                                        Decimal {
                                                            Scale = 0
                                                        }
                                                    ],
                                                    [
                                                        Decimal {
                                                            Scale = 0
                                                        },
                                                        Decimal {
                                                            Scale = 0
                                                        },
                                                        Decimal {
                                                            Scale = 0
                                                        }
                                                    ]
                                                ],
                                                Open = False,
                                                Mottos = [
                                                    Fail whale
                                                ],
                                                Other = [
                                                    [
                                                        [
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            }
                                                        ],
                                                        [
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            }
                                                        ],
                                                        [
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            }
                                                        ]
                                                    ],
                                                    [
                                                        10,
                                                        9,
                                                        8,
                                                        7,
                                                        6,
                                                        5,
                                                        3,
                                                        2,
                                                        1
                                                    ],
                                                    [
                                                        Fail whale
                                                    ]
                                                ],
                                                Nested = [
                                                    List`1 (skipped)
                                                ],
                                                MyType = Type (RuntimeType)
                                            }
                                            """),
    };

    public static TheoryData<ValueType, string, IndentationStyle> RecordStructs() => new() {
        TestGenerator.TheoryData<ValueType>(new Complex.ComplexRecordStruct(),
                                            "ComplexRecordStruct { Established = 10/30/1999 04:02:21, Employees = 999, PeoplePerRoom = [ 10, 9, 8, 7, 6, 5, 3, 2, 1 ], Symbol = @, Cost = 100980.1, Product = { [ Name ] = ProductName!, [ ExpiryDate ] = 5/20/2026 00:00:00, [ Price ] = 9.9, [ Sizes ] = null, [ This ] = ComplexRecordStruct { Established = 10/30/1999 04:02:21, Employees = 999, PeoplePerRoom = [ 10, 9, 8, 7, 6, 5, 3, 2, 1 ], Symbol = @, Cost = 100980.1, Product = Dictionary`2 (skipped), Color = Color { R = 240, G = 248, B = 255, A = 255, IsKnownColor = True, IsEmpty = False, IsNamedColor = True, IsSystemColor = False, Name = AliceBlue }, Width = 99.99, RoomsPerFloor = [ [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ] ], Open = False, Mottos = [ Fail whale ], Other = null, Nested = [ List`1 (skipped) ], MyType = Type (RuntimeType) }, [ Itself ] = Dictionary`2 (skipped), [ Rooms ] = [ [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ] ] }, Color = Color { R = 240, G = 248, B = 255, A = 255, IsKnownColor = True, IsEmpty = False, IsNamedColor = True, IsSystemColor = False, Name = AliceBlue }, Width = 99.99, RoomsPerFloor = [ [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ] ], Open = False, Mottos = [ Fail whale ], Other = [ [ [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ], [ Decimal { Scale = 0 }, Decimal { Scale = 0 }, Decimal { Scale = 0 } ] ], [ 10, 9, 8, 7, 6, 5, 3, 2, 1 ], [ Fail whale ] ], Nested = [ List`1 (skipped) ], MyType = Type (RuntimeType) }",
                                            """
                                            ComplexRecordStruct {
                                                Established = 10/30/1999 04:02:21, Employees = 999,
                                                PeoplePerRoom = [ 10, 9, 8, 7, 6, 5, 3, 2, 1 ], Symbol = @, Cost = 100980.1,
                                                Product = { [ Name ] = ProductName!,
                                                    [ ExpiryDate ] = 5/20/2026 00:00:00, [ Price ] = 9.9, [ Sizes ] = null,
                                                    [ This ] = ComplexRecordStruct {
                                                        Established = 10/30/1999 04:02:21, Employees = 999,
                                                        PeoplePerRoom = [ 10, 9, 8, 7, 6, 5, 3, 2, 1 ], Symbol = @, Cost = 100980.1,
                                                        Product = Dictionary`2 (skipped),
                                                        Color = Color { R = 240, G = 248, B = 255, A = 255, IsKnownColor = True, IsEmpty = False, IsNamedColor = True, IsSystemColor = False, Name = AliceBlue }, Width = 99.99,
                                                        RoomsPerFloor = [
                                                            [
                                                                Decimal { Scale = 0 },
                                                                Decimal { Scale = 0 },
                                                                Decimal { Scale = 0 }
                                                            ],
                                                            [
                                                                Decimal { Scale = 0 },
                                                                Decimal { Scale = 0 },
                                                                Decimal { Scale = 0 }
                                                            ],
                                                            [
                                                                Decimal { Scale = 0 },
                                                                Decimal { Scale = 0 },
                                                                Decimal { Scale = 0 }
                                                            ]
                                                        ], Open = False,
                                                        Mottos = [ Fail whale ], Other = null,
                                                        Nested = [
                                                            List`1 (skipped)
                                                        ],
                                                        MyType = Type (RuntimeType)
                                                    },
                                                    [ Itself ] = Dictionary`2 (skipped),
                                                    [ Rooms ] = [
                                                        [
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 }
                                                        ],
                                                        [
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 }
                                                        ],
                                                        [
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 }
                                                        ]
                                                    ]
                                                },
                                                Color = Color { R = 240, G = 248, B = 255, A = 255, IsKnownColor = True, IsEmpty = False, IsNamedColor = True, IsSystemColor = False, Name = AliceBlue }, Width = 99.99,
                                                RoomsPerFloor = [
                                                    [
                                                        Decimal { Scale = 0 },
                                                        Decimal { Scale = 0 },
                                                        Decimal { Scale = 0 }
                                                    ],
                                                    [
                                                        Decimal { Scale = 0 },
                                                        Decimal { Scale = 0 },
                                                        Decimal { Scale = 0 }
                                                    ],
                                                    [
                                                        Decimal { Scale = 0 },
                                                        Decimal { Scale = 0 },
                                                        Decimal { Scale = 0 }
                                                    ]
                                                ], Open = False,
                                                Mottos = [ Fail whale ],
                                                Other = [
                                                    [
                                                        [
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 }
                                                        ],
                                                        [
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 }
                                                        ],
                                                        [
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 },
                                                            Decimal { Scale = 0 }
                                                        ]
                                                    ],
                                                    [ 10, 9, 8, 7, 6, 5, 3, 2, 1 ],
                                                    [ Fail whale ]
                                                ],
                                                Nested = [
                                                    List`1 (skipped)
                                                ],
                                                MyType = Type (RuntimeType)
                                            }
                                            """,
                                            """
                                            ComplexRecordStruct {
                                                Established = 10/30/1999 04:02:21,
                                                Employees = 999,
                                                PeoplePerRoom = [
                                                    10,
                                                    9,
                                                    8,
                                                    7,
                                                    6,
                                                    5,
                                                    3,
                                                    2,
                                                    1
                                                ],
                                                Symbol = @,
                                                Cost = 100980.1,
                                                Product = {
                                                    [ Name ] = ProductName!,
                                                    [ ExpiryDate ] = 5/20/2026 00:00:00,
                                                    [ Price ] = 9.9,
                                                    [ Sizes ] = null,
                                                    [ This ] = ComplexRecordStruct {
                                                        Established = 10/30/1999 04:02:21,
                                                        Employees = 999,
                                                        PeoplePerRoom = [
                                                            10,
                                                            9,
                                                            8,
                                                            7,
                                                            6,
                                                            5,
                                                            3,
                                                            2,
                                                            1
                                                        ],
                                                        Symbol = @,
                                                        Cost = 100980.1,
                                                        Product = Dictionary`2 (skipped),
                                                        Color = Color {
                                                            R = 240,
                                                            G = 248,
                                                            B = 255,
                                                            A = 255,
                                                            IsKnownColor = True,
                                                            IsEmpty = False,
                                                            IsNamedColor = True,
                                                            IsSystemColor = False,
                                                            Name = AliceBlue
                                                        },
                                                        Width = 99.99,
                                                        RoomsPerFloor = [
                                                            [
                                                                Decimal {
                                                                    Scale = 0
                                                                },
                                                                Decimal {
                                                                    Scale = 0
                                                                },
                                                                Decimal {
                                                                    Scale = 0
                                                                }
                                                            ],
                                                            [
                                                                Decimal {
                                                                    Scale = 0
                                                                },
                                                                Decimal {
                                                                    Scale = 0
                                                                },
                                                                Decimal {
                                                                    Scale = 0
                                                                }
                                                            ],
                                                            [
                                                                Decimal {
                                                                    Scale = 0
                                                                },
                                                                Decimal {
                                                                    Scale = 0
                                                                },
                                                                Decimal {
                                                                    Scale = 0
                                                                }
                                                            ]
                                                        ],
                                                        Open = False,
                                                        Mottos = [
                                                            Fail whale
                                                        ],
                                                        Other = null,
                                                        Nested = [
                                                            List`1 (skipped)
                                                        ],
                                                        MyType = Type (RuntimeType)
                                                    },
                                                    [ Itself ] = Dictionary`2 (skipped),
                                                    [ Rooms ] = [
                                                        [
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            }
                                                        ],
                                                        [
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            }
                                                        ],
                                                        [
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            }
                                                        ]
                                                    ]
                                                },
                                                Color = Color {
                                                    R = 240,
                                                    G = 248,
                                                    B = 255,
                                                    A = 255,
                                                    IsKnownColor = True,
                                                    IsEmpty = False,
                                                    IsNamedColor = True,
                                                    IsSystemColor = False,
                                                    Name = AliceBlue
                                                },
                                                Width = 99.99,
                                                RoomsPerFloor = [
                                                    [
                                                        Decimal {
                                                            Scale = 0
                                                        },
                                                        Decimal {
                                                            Scale = 0
                                                        },
                                                        Decimal {
                                                            Scale = 0
                                                        }
                                                    ],
                                                    [
                                                        Decimal {
                                                            Scale = 0
                                                        },
                                                        Decimal {
                                                            Scale = 0
                                                        },
                                                        Decimal {
                                                            Scale = 0
                                                        }
                                                    ],
                                                    [
                                                        Decimal {
                                                            Scale = 0
                                                        },
                                                        Decimal {
                                                            Scale = 0
                                                        },
                                                        Decimal {
                                                            Scale = 0
                                                        }
                                                    ]
                                                ],
                                                Open = False,
                                                Mottos = [
                                                    Fail whale
                                                ],
                                                Other = [
                                                    [
                                                        [
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            }
                                                        ],
                                                        [
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            }
                                                        ],
                                                        [
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            },
                                                            Decimal {
                                                                Scale = 0
                                                            }
                                                        ]
                                                    ],
                                                    [
                                                        10,
                                                        9,
                                                        8,
                                                        7,
                                                        6,
                                                        5,
                                                        3,
                                                        2,
                                                        1
                                                    ],
                                                    [
                                                        Fail whale
                                                    ]
                                                ],
                                                Nested = [
                                                    List`1 (skipped)
                                                ],
                                                MyType = Type (RuntimeType)
                                            }
                                            """),
    };
}