using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace persistentbugger
{
    class Program
    {
        static void Main(string[] args)
        {
            Persist.Persistence(4);
        }
    }
    public class Persist
    {
        public static int Persistence(long n)
        {
            var tmp = new Queue<int>(n.ToString().Select(x => x - '0'));
            int count;
            for (count = 0; tmp.Count() != 1; count++)
            {
                var value = 1;
                for (int i = 0; tmp.Count != 0; i++)
                {
                    value *= tmp.Dequeue();
                }
                tmp = new Queue<int>(value.ToString().Select(x => x - '0'));
            }
            return count;
        }
    }
}
