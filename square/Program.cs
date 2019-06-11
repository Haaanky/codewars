using System;

namespace square
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata.IsSquare(-1);
            Kata.IsSquare(3);
            Kata.IsSquare(4);
            Kata.IsSquare(25);
            Kata.IsSquare(26);
        }
    }
    public class Kata
    {
        public static bool IsSquare(int n)
        {
            return Math.Sqrt(n)%1 == 0;
        }
    }
}
