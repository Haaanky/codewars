using System;
using System.Linq;
using System.Text;

namespace mumbling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Accumul.Accum("ZpglnRxqenU"));

        }
    }
    public class Accumul
    {
        public static String Accum(string s)
        {
            var result = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    result.Append(j == 0?s.ToUpper()[i]:s.ToLower()[i]);
                }
                result.Append(i != s.Length - 1?"-":"");
            }
            return result.ToString();
        }
    }
}
