using System;
using System.Linq;

namespace highlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata.HighAndLow("1 2 3 4 5");  // return "5 1"
            Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
            Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"
        }
    }
    public static class Kata
    {
        public static string HighAndLow(string numbers)
        {
            return $"{numbers.Split().Max()} {numbers.Split().Min(x => int.Parse(x))}";
        }
    }
}
