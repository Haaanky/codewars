using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace doublecola
{
    class Program
    {
        static void Main(string[] args)
        {
            Line.WhoIsNext(new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" }, 2);
        }
    }

    public class Line
    {
        public static string WhoIsNext(string[] names, long n)
        {
            //var lineQueue = new Queue<string>(names);
            //var lineQueue = new List<string>(names);
            var lineQueue = new string[names.Length + 2];
            int i;
            for (i = 0; i < n; i++)
            {
                //var pop = lineQueue.Dequeue();
                //lineQueue.Enqueue(pop);
                //lineQueue.Enqueue(pop);
                //lineQueue.Add(lineQueue[i]);
                //lineQueue.Add(lineQueue[i]);
                //for (int j = 0; j < names.Length; j++)
                //{

                //}
                //lineQueue[names.Length + 1] = names[0];
                //lineQueue[names.Length + 2] = names[0];
                //names[i] = null;
            }
            int j = 0;
            while (i++ < n)
            {
                j++;
                if (j == names.Length)
                    j = 0;
            }
            //Console.WriteLine(lineQueue[i - 1]);
            Console.WriteLine(names[j]);
            return lineQueue[i - 1];
        }
    }
}
