using System;
using System.Collections.Generic;
using System.Linq;

namespace Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Parentheses.ValidParentheses("()");
            Parentheses.ValidParentheses(")((((");
            Parentheses.ValidParentheses("(())((()())())");
            Parentheses.ValidParentheses("(())((()())())(");
        }
    }
    public class Parentheses
    {
        const char a = '(';
        const char b = ')';

        public static bool ValidParentheses(string input)
        {
            var tmp = input.Where(x => x == a || x == b).ToList();
            var matchingParan = new List<char>();

            var length = input.Length / 2;

            for (int i = 0; i <= length; i++)
            {
                input = input.Replace("()", string.Empty);
            }

            return input == string.Empty;


            if (tmp.Any())
            {
                for (int i = 0; tmp.Count != matchingParan.Count && i < tmp.Count; i++)
                {
                    //Int64.Parse
                    if (tmp[i] == a)
                        for (int j = i+1; j < tmp.Count; j++)
                        {
                            if (tmp[j] == b)
                            {
                                //tmp.RemoveAt(j);
                                //tmp.RemoveAt(i);
                                matchingParan.Add(tmp[i]);
                                matchingParan.Add(tmp[j]);
                                break;
                            }
                        }
                    else
                        for (int j = 0; j < i; j++)
                        {
                            if (tmp[j] == a)
                            {
                                //tmp.RemoveAt(j);
                                //tmp.RemoveAt(i+1);
                                matchingParan.Add(tmp[i]);
                                matchingParan.Add(tmp[j]);
                                break;
                            }
                        }
                }
                return tmp.Count == matchingParan.Count;
            }
            return false;
        }
    }
}
