using System;
using System.Collections.Generic;
using System.Text;

namespace _20261109_LinqDemo
{
    public static class Utility
    {
        public static int Sqr(this int n)
        {
            return n * n;
        }

        public static IEnumerable<int> MakeDouble(this IEnumerable<int> source)
        {
            List<int> result = new List<int>();

            foreach (int item in source)
            {
                result.Add(item);
                result.Add(item);
            }

            return result;
        }

        
    }
}

