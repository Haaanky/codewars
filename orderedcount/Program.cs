using System;
using System.Collections.Generic;
using System.Linq;

namespace orderedcount
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata.OrderedCount("abbccc");
            Console.WriteLine();
        }
    }
    public class Kata
    {
        public static List<Tuple<char, int>> OrderedCount(string input)
        {
            var result = new List<Tuple<char, int>>();
            foreach (var item in input.Distinct().OrderBy(x => x))
            {
                result.Add(new Tuple<char, int>(item, input.Count(x => x == item)));
            }
            return result;
        }
    }
}
