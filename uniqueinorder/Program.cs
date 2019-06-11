using System;
using System.Collections.Generic;
using System.Linq;

namespace uniqueinorder
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata.UniqueInOrder("AAAABBBCCDAABBB");/* == ['A', 'B', 'C', 'D', 'A', 'B']*/
            Kata.UniqueInOrder("ABBCcAD"); /*== ['A', 'B', 'C', 'c', 'A', 'D']*/
            Kata.UniqueInOrder(new int[5] { 1, 2, 2, 3, 3 });       /*== [1, 2, 3]*/
        }
    }
    public static class Kata
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var list = new List<T>(iterable);
            var result = new List<T>();

            for (int i = 0; i < list.Count - 1; i++)
            {
                //result.Add(iterable.First());
                if (list[i].Equals(list[i + 1]))
                {
                    list.RemoveAt(i + 1);
                    i--;
                }
            }
            return list;
        }
    }
}
