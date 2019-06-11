using System;

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
            return Convert.ToDecimal(double.Parse(a, System.Globalization.NumberStyles.Any) + double.Parse(b, System.Globalization.NumberStyles.AllowDecimalPoint)).ToString();
        }
    }
}
