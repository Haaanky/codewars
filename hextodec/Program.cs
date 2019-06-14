using System;
using System.Globalization;

namespace hextodec
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata.HexToDec("1");
            Kata.HexToDec("a");
            Kata.HexToDec("10");
            Kata.HexToDec("FF");
            Console.WriteLine(Kata.HexToDec("-C"));
        }
    }
    public class Kata
    {
        public static int HexToDec(string hexString)
        {
            return hexString.Contains('-') ? -1 * int.Parse(hexString.Substring(1), NumberStyles.HexNumber) : int.Parse(hexString, NumberStyles.HexNumber);
        }
    }
}
