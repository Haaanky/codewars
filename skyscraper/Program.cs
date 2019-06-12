using System;
using System.Collections.Generic;
using System.Linq;

namespace skyscraper
{
    class Program
    {
        static void Main(string[] args)
        {
            Skyscrapers.SolvePuzzle(new int[]{ 2, 2, 1, 3,
                                               2, 2, 3, 1,
                                               1, 2, 2, 3,
                                               3, 2, 1, 3});
        }
    }
    public class Skyscrapers
    {
        public static int[][] SolvePuzzle(int[] clues)
        {
            var matchingClues = new List<(int, int)>();
            matchingClues.Add((clues[0], clues[11]));
            matchingClues.Add((clues[1], clues[10]));
            matchingClues.Add((clues[2], clues[9]));
            matchingClues.Add((clues[3], clues[8]));

            matchingClues.Add((clues[4], clues[15]));
            matchingClues.Add((clues[5], clues[14]));
            matchingClues.Add((clues[6], clues[13]));
            matchingClues.Add((clues[7], clues[12]));

            //var x = 11;
            //for (int i = 0; i < clues.Length / 2; i++)
            //{
            //    if (i < 4)
            //        matchingClues.Add((clues[i], clues[11 - i]));
            //    else
            //    {
            //        matchingClues.Add((clues[i], clues[i + x]));
            //        x -= 2;
            //    }
            //}
            var result = new int[4][] { new int[4], new int[4], new int[4], new int[4] };
            PrintBoard(result);
            return FillBoard(matchingClues, result);
        }

        private static int[][] FillBoard(List<(int, int)> clues, int[][] result)
        {
            var x = 1;
            for (int i = 0; i < clues.Count; i++)
            {
                if (clues[i].Item1 == 4)
                {
                    for (int j = 0; j < 4; j++)
                        result[i][j] = x++;
                    continue;
                } else if(clues[i].Item1 == 3)
                {

                }
            }
            foreach (var item in result)
            {
                foreach (var height in item)
                {
                    Console.Write(height);
                }
                Console.WriteLine();
            }
            return result;
        }
        private static void PrintBoard(int[][] result)
        {
            foreach (var item in result)
            {
                foreach (var height in item)
                {
                    Console.Write(height);
                }
                Console.WriteLine();
            }
        }
    }

}
