using System;
using System.Linq;

namespace sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Sudoku.ValidateSolution(new int[][]
                {
                  new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
                  new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
                  new int[] {1, 9, 8, 3, 4, 2, 5, 6, 7},
                  new int[] {8, 5, 9, 7, 6, 1, 4, 2, 3},
                  new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
                  new int[] {7, 1, 3, 9, 2, 4, 8, 5, 6},
                  new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
                  new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
                  new int[] {3, 4, 5, 2, 8, 6, 1, 7, 9},
                });
            a = Sudoku.ValidateSolution(new int[][]
                {
                  new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
                  new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
                  new int[] {1, 9, 8, 3, 4, 2, 5, 6, 7},
                  new int[] {8, 5, 9, 7, 6, 1, 4, 2, 3},
                  new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
                  new int[] {7, 1, 3, 9, 2, 4, 8, 5, 6},
                  new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
                  new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
                  new int[] {3, 0, 0, 4, 8, 1, 1, 7, 9},
                });
            a = Sudoku.ValidateSolution(new int[][]
                {
                    new int[] {1, 2, 6, 3, 4, 7, 5, 9, 8},
                    new int[] {7, 3, 5, 8, 1, 9, 6, 4, 2},
                    new int[] {1, 9, 4, 2, 6, 5, 8, 7, 3},
                    new int[] {3, 1, 7, 5, 8, 4, 2, 6, 9},
                    new int[] {6, 5, 9, 1, 7, 2, 4, 3, 8},
                    new int[] {4, 8, 2, 9, 3, 6, 7, 1, 5},
                    new int[] {9, 4, 8, 7, 5, 1, 3, 2, 6},
                    new int[] {5, 6, 1, 4, 2, 3, 9, 8, 7},
                    new int[] {2, 7, 3, 6, 9, 8, 1, 5, 4},
                });
            a = Sudoku.ValidateSolution(new int[][]
                {
                    new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9},
                    new int[] {2, 3, 1, 5, 6, 4, 8, 9, 7},
                    new int[] {3, 1, 2, 6, 4, 5, 9, 7, 8},
                    new int[] {4, 5, 6, 7, 8, 9, 1, 2, 3},
                    new int[] {5, 6, 4, 8, 9, 7, 2, 3, 1},
                    new int[] {6, 4, 5, 9, 7, 8, 3, 1, 2},
                    new int[] {7, 8, 9, 1, 2, 3, 4, 5, 6},
                    new int[] {8, 9, 7, 2, 3, 1, 5, 6, 4},
                    new int[] {9, 7, 8, 3, 1, 2, 6, 4, 5},
                });
            a = Sudoku.ValidateSolution(new int[][]
                {
                    new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9},
                    new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9},
                    new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9},
                    new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9},
                    new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9},
                    new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9},
                    new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9},
                    new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9},
                    new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9},
                });
        }
    }
    public class Sudoku
    {
        public static bool ValidateSolution(int[][] board)
        {
            if (board.All(x => !x.Contains(0) && x.Distinct().Count() == x.Length))
            {
                var boardOfBoardsArray = new int[9][][] {
                    new int[3][] {
                        new int[3],
                        new int[3],
                        new int[3] },
                    new int[3][] {
                        new int[3],
                        new int[3],
                        new int[3] },
                    new int[3][] {
                        new int[3],
                        new int[3],
                        new int[3] },
                    new int[3][] {
                        new int[3],
                        new int[3],
                        new int[3] },
                    new int[3][] {
                        new int[3],
                        new int[3],
                        new int[3] },
                    new int[3][] {
                        new int[3],
                        new int[3],
                        new int[3] },
                    new int[3][] {
                        new int[3],
                        new int[3],
                        new int[3] },
                    new int[3][] {
                        new int[3],
                        new int[3],
                        new int[3] },
                    new int[3][] {
                        new int[3],
                        new int[3],
                        new int[3] }};
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            boardOfBoardsArray[i][j][k] = board[j][k];  // de nio siffrorna i boardofboards måste bara vara 1-9, ordning spelar ingen roll
                        }
                    }
                }
                PrintBoard(board);
                Console.WriteLine();
                PrintBoard(boardOfBoardsArray);
                var invertedArray = new int[9][] { new int[9], new int[9], new int[9], new int[9], new int[9], new int[9], new int[9], new int[9], new int[9] };
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        invertedArray[i][j] = board[j][i];
                    }
                }
                //PrintBoard(board);
                //Console.WriteLine();
                //PrintBoard(invertedArray);
                if (invertedArray.All(x => !x.Contains(0) && x.Distinct().Count() == x.Length))
                    return true;
            }
            return false;
            //return board.All(x => x.All(y => y == 1 || y == 2 || y == 3 || y == 4 || y == 5 || y == 6 || y == 7 || y == 8 || y == 9));
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
        private static void PrintBoard(int[][][] result)
        {
            foreach (var item in result)
            {
                foreach (var height in item)
                {
                    foreach (var point in height)
                    {
                        Console.Write(point);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
