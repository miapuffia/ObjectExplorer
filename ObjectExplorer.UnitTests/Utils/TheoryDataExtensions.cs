using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectExplorer.UnitTests.Utils;

public static class TheoryDataExtensions {
    extension<T1, T2>(TheoryData<T1, T2> theoryData) {
        public void Add(IEnumerable<(T1, T2)> items) {
            foreach (var item in items) {
                theoryData.Add(item.Item1, item.Item2);
            }
        }

        public void Add(TheoryData<T1, T2> items) {
            foreach (var item in items) {
                theoryData.Add((T1) item.Data.Item1, (T2) item.Data.Item2);
            }
        }
    }

    extension<T1, T2, T3>(TheoryData<T1, T2, T3> theoryData) {
        public void Add(IEnumerable<(T1, T2, T3)> items) {
            foreach (var item in items) {
                theoryData.Add(item.Item1, item.Item2, item.Item3);
            }
        }

        public void Add(TheoryData<T1, T2, T3> items) {
            foreach (var item in items) {
                theoryData.Add((T1) item.Data.Item1, (T2) item.Data.Item2, (T3) item.Data.Item3);
            }
        }
    }
}
