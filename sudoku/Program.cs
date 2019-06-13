using System;
using System.Collections.Generic;
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
                var boardOfBoards = new int[9][] { new int[9], new int[9], new int[9], new int[9], new int[9], new int[9], new int[9], new int[9], new int[9] };
                var queue = new Queue<int>[9] { new Queue<int>(board[0]), new Queue<int>(board[1]), new Queue<int>(board[2]), new Queue<int>(board[3]), new Queue<int>(board[4]), new Queue<int>(board[5]), new Queue<int>(board[6]), new Queue<int>(board[7]), new Queue<int>(board[8]) };

                for (int i = 0; i < queue.Length; i++)
                {
                    //Queue<int> item = (Queue<int>)queue[i];
                    if (i < 3)
                        for (int j = 0; j < 9; j++)
                        {
                            if (j < 3)
                                boardOfBoards[i][j] = queue[0].Dequeue();
                            else if (j < 6)
                                boardOfBoards[i][j] = queue[1].Dequeue();
                            else
                                boardOfBoards[i][j] = queue[2].Dequeue();
                        }
                    else if (i >= 3 && i < 6)
                        for (int j = 0; j < 9; j++)
                        {
                            if (j < 3)
                                boardOfBoards[i][j] = queue[3].Dequeue();
                            else if (j < 6)
                                boardOfBoards[i][j] = queue[4].Dequeue();
                            else
                                boardOfBoards[i][j] = queue[5].Dequeue();
                        }
                    else
                        for (int j = 0; j < 9; j++)
                        {
                            if (j < 3)
                                boardOfBoards[i][j] = queue[6].Dequeue();
                            else if (j < 6)
                                boardOfBoards[i][j] = queue[7].Dequeue();
                            else
                                boardOfBoards[i][j] = queue[8].Dequeue();
                        }
                }

                //for (int i = 0; i < board.Length; i++)
                //{
                //    for (int j = 0; j < 9; j++)
                //    {
                //        boardOfBoards[i][0] = board[0][0]; // i || j 
                //        boardOfBoards[i][1] = board[0][1]; // i || j 
                //        boardOfBoards[i][2] = board[0][2]; // i || j 

                //        boardOfBoards[i][3] = board[1][0]; // i + 1 || j - 3
                //        boardOfBoards[i][4] = board[1][1]; // i + 1 || j - 3
                //        boardOfBoards[i][5] = board[1][2]; // i + 1 || j - 3

                //        boardOfBoards[i][6] = board[2][0]; // i + 2 || j - 6
                //        boardOfBoards[i][7] = board[2][1]; // i + 2 || j - 6
                //        boardOfBoards[i][8] = board[2][2]; // i + 2 || j - 6

                //        /////////////////////////////////////////////////////

                //        boardOfBoards[1][0] = board[3][0]; // i + 2 || j 
                //        boardOfBoards[1][1] = board[3][1]; // i + 2 || j 
                //        boardOfBoards[1][2] = board[3][2]; // i + 2 || j 

                //        boardOfBoards[1][3] = board[4][0]; // i + 3 || j - 3
                //        boardOfBoards[1][4] = board[4][1]; // i + 3 || j - 3
                //        boardOfBoards[1][5] = board[4][2]; // i + 3 || j - 3

                //        boardOfBoards[1][6] = board[5][0]; // i + 4 || j - 6
                //        boardOfBoards[1][7] = board[5][1]; // i + 4 || j - 6
                //        boardOfBoards[1][8] = board[5][2]; // i + 4 || j - 6

                //        /////////////////////////////////////////////////////

                //        boardOfBoards[2][0] = board[6][0]; // i + 4 || j 
                //        boardOfBoards[2][1] = board[6][1]; // i + 4 || j 
                //        boardOfBoards[2][2] = board[6][2]; // i + 4 || j 

                //        boardOfBoards[2][3] = board[7][0]; // i + 5 || j - 3 
                //        boardOfBoards[2][4] = board[7][1]; // i + 5 || j - 3 
                //        boardOfBoards[2][5] = board[7][2]; // i + 5 || j - 3 

                //        boardOfBoards[2][6] = board[8][0]; // i + 6 || j - 6
                //        boardOfBoards[2][7] = board[8][1]; // i + 6 || j - 6
                //        boardOfBoards[2][8] = board[8][2]; // i + 6 || j - 6
                //    }
                //}
                //var boardOfBoardsArray = new int[9][][] {
                //    new int[3][] {
                //        new int[3],
                //        new int[3],
                //        new int[3] },
                //    new int[3][] {
                //        new int[3],
                //        new int[3],
                //        new int[3] },
                //    new int[3][] {
                //        new int[3],
                //        new int[3],
                //        new int[3] },
                //    new int[3][] {
                //        new int[3],
                //        new int[3],
                //        new int[3] },
                //    new int[3][] {
                //        new int[3],
                //        new int[3],
                //        new int[3] },
                //    new int[3][] {
                //        new int[3],
                //        new int[3],
                //        new int[3] },
                //    new int[3][] {
                //        new int[3],
                //        new int[3],
                //        new int[3] },
                //    new int[3][] {
                //        new int[3],
                //        new int[3],
                //        new int[3] },
                //    new int[3][] {
                //        new int[3],
                //        new int[3],
                //        new int[3] }};

                //for (int i = 0; i < 9; i++)
                //{
                //    for (int j = 0; j < 3; j++)
                //    {
                //        for (int k = 0; k < 3; k++)
                //        {
                //            boardOfBoardsArray[i][j][k] = board[j][k];  // de nio siffrorna i boardofboards måste bara vara 1-9, ordning spelar ingen roll
                //        }
                //    }
                //}
                //PrintBoard(board);
                //Console.WriteLine();
                if (boardOfBoards.All(x => !x.Contains(0) && x.Distinct().Count() == x.Length))
                {
                    var invertedArray = new int[9][] { new int[9], new int[9], new int[9], new int[9], new int[9], new int[9], new int[9], new int[9], new int[9] };
                    for (int i = 0; i < 9; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            invertedArray[i][j] = board[j][i];
                        }
                    }
                    if (invertedArray.All(x => !x.Contains(0) && x.Distinct().Count() == x.Length))
                        return true;
                }
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
