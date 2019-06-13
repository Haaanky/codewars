using System;
using System.Numerics;

namespace sumstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.sumStrings("999999999999999999", "6999999999999999999"));
        }
    }
    public static class Kata
    {
        public static string sumStrings(string a, string b)
        {
            if (a == string.Empty)
                return b;
            else if (b == string.Empty)
                return a;

            return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
        }
    }
}
