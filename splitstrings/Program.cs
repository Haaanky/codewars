using System;
using System.Collections.Generic;

namespace splitstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            SplitString.Solution("abc");
            SplitString.Solution("abcdef");
        }
    }
    public class SplitString
    {
        public static string[] Solution(string str)
        {
            var result = new List<string>();
            if (!(str.Length % 2 == 0))
            {
                int i;
                for (i = 0; i < str.Length - 2; i += 2)
                    result.Add(str.Substring(i, 2));
                result.Add(str.Substring(i, 1) + "_");
                return result.ToArray();
            }

            for (int i = 0; i < str.Length; i += 2)
                result.Add(str.Substring(i, 2));
            return result.ToArray();
        }
    }
}
