using System;
using System.Linq;

namespace greedisgood
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Score(new int[] { 2, 3, 4, 6, 2 })); // 0
            Console.WriteLine(Kata.Score(new int[] { 4, 4, 4, 3, 3 })); // "Should be 400"
            Console.WriteLine(Kata.Score(new int[] { 3, 3, 3, 3, 3 })); // "Should be 300"
        }
    }
    public static class Kata
    {
        public static int Score(int[] dice)
        {
            var score = 0;
            var tmp = dice.GroupBy(x => x);
            foreach (var item in tmp)
            {
                switch (item.Key)
                {
                    case 1:
                        switch (item.Count())
                        {
                            case 1:
                                score += 100;
                                break;
                            case 2:
                                score += 200;
                                break;
                            case 3:
                                score += 1000;
                                break;
                            case 4:
                                score += 1100;
                                break;
                            case 5:
                                return 1200;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        if (item.Count() >= 3)
                            score += 200;
                        break;
                    case 3:
                        if (item.Count() >= 3)
                            score += 300; break;
                    case 4:
                        if (item.Count() >= 3)
                            score += 400; break;
                    case 5:
                        switch (item.Count())
                        {
                            case 1:
                                score += 50;
                                break;
                            case 2:
                                score += 100;
                                break;
                            case 3:
                                score += 500;
                                break;
                            case 4:
                                score += 550;
                                break;
                            case 5:
                                return 600;
                            default:
                                break;
                        }
                        break;

                    case 6:
                        if (item.Count() >= 3)
                            score += 600; break;
                    default:
                        break;
                }
            }
            return score;
        }
    }
}
