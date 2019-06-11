using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace jadencase
{
    class Program
    {
        static void Main(string[] args)
        {
            "If everybody in the world dropped out of school we would have a much more intelligent society.".ToJadenCase();
            "Young Jaden: Here's the deal for every time out you give me, you'll give me 15 dollars for therapy when I get older.".ToJadenCase();
            "We need to stop teaching the Youth about the Past and encourage them to change the Future.".ToJadenCase();

        }
    }
    public static class JadenCase
    {
        public static string ToJadenCase(this string phrase)
        {
            var split = phrase.Split();
            foreach (var item in split)
            {
                string tmp;
                tmp = item[0].ToString().ToUpper();
                switch (item.Length)
                {
                    case 1:
                        phrase = phrase.Replace($" {item} ", $" {tmp} ");
                        phrase = phrase.Replace($"{item} ", $"{tmp} ");
                        phrase = phrase.Replace($" {item}", $" {tmp}");
                        break;
                    case 2:
                        tmp += item.Substring(1);
                        phrase = phrase.Replace($" {item} ", $" {tmp} ");
                        if (phrase.IndexOf(item) == 0)
                            phrase = phrase.Replace($"{item} ", $"{tmp} ");
                        if (phrase.IndexOf(item) == phrase.Length - 2)
                            phrase = phrase.Replace($" {item}", $" {tmp}");
                        break;
                    default:
                        tmp += item.Substring(1);
                        Regex regex = new Regex(item);
                        phrase = regex.Replace(phrase, tmp, 1);
                        break;
                }
            }
            return phrase;
        }
    }
}
