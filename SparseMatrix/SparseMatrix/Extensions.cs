using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparseMatrix
{
    public static class IEnumerableExt
    {
        public static int Product(this IEnumerable<int> src) => src.Aggregate(1, (a, n) => a * n);
    }

    public static class StringExt
    {
        public static string Join<T>(this IEnumerable<T> items, string sep) => String.Join(sep, items);
    }
}
