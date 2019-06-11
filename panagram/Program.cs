using System;
using System.Linq;

namespace panagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata.IsPangram("ABCD45EFGH,IJK,LMNOPQR56STUVW3XYZ");
        }
    }
    public static class Kata
    {
        public static bool IsPangram(string str)
        {
            str = String.Concat(str.Where(char.IsLetter)).ToLower();
            foreach (var item in Enumerable.Range('a', 'z' - 'a' + 1).Select(x => (char)x))
            {
                if (!str.Contains(item))
                    return false;
            }

            return true;
        }
    }
}
