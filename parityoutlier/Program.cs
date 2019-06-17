using System;
using System.Linq;

namespace parityoutlier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Find(new int[] { 1, -3, 9, -10, 3, 19 }));
        }
    }
    public class Kata
    {
        public static int Find(int[] integers)
        {
            return integers.GroupBy(x => x % 2 == 0).Where(x => x.Count() == 1).Single().Single();
        }
    }
}
