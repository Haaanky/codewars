using System;

namespace middlechar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.GetMiddle("A"));
        }
    }
    public class Kata
    {
        public static string GetMiddle(string s)
        {
            return s.Length % 2 == 0 ? s.Substring((int)Math.Round((s.Length / 2.0), MidpointRounding.AwayFromZero) - 1, 2) : s[s.Length / 2].ToString();
        }
    }
}
