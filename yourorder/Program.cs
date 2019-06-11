using System;
using System.Collections.Generic;
using System.Text;

namespace yourorder
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = Kata.Order("is2 Thi1s T4est 3a");
        }
    }
    public static class Kata
    {
        public static string Order(string words)
        {
            var sb = new StringBuilder();
            var split = words.Split();

            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j < split.Length; j++)
                {
                    if (split[j].Contains(i.ToString()))
                        sb.Append(split[j] + " ");
                }
            }
            return sb.ToString().TrimEnd();
        }
    }
}
