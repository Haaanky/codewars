using System;
using System.Linq;

namespace oddnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.find_it(new int[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }
    }
    class Kata
    {
        public static int find_it(int[] seq)
        {
            foreach (var item in seq.GroupBy(x => x))
            {
                if (item.Count() % 2 != 0)
                    return item.Key;
            }
            return -1;
        }

    }
}
