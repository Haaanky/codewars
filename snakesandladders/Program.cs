using System;
using System.Collections.Generic;

namespace snakesandladders
{
    class Program
    {
        static void Main(string[] args)
        {
            SnakesLadders game = new SnakesLadders();
            game.play(6, 2);
            game.play(6, 2);
        }
    }
    class SnakesLadders
    {
        private GameBoard gameBoard;
        private Player playerOne;
        private Player playerTwo;
        private int round = 1;
        public SnakesLadders()
        {
            gameBoard = new GameBoard(100);
            playerOne = new Player(0, 1);
            playerTwo = new Player(0, 2);
        }
        public string play(int die1, int die2)
        {
            if (round++ % 2 != 0)
            {
                //insert gamelogic here, will be same as below so should be refactored
                playerOne.ActivePlayer = true;
            }
            else
            {
                playerTwo.ActivePlayer = true;
            }

            return "";
        }
    }

    internal class Player
    {
        public Player(int placement, int Id)
        {
            Location = placement;
            ID = Id;
        }
        public int Location { get; set; }
        public int ID { get; set; }
        public bool ActivePlayer { get; set; } = false;
    }

    internal class GameBoard
    {
        public GameBoard(int squares)
        {
            Squares = new int[squares];
            Ladders = new Dictionary<int, int> {
            { 2, 38 },
            { 7, 14},
            { 8, 31},
            { 15, 26},
            { 21, 42},
            { 28, 84},
            { 36, 44},
            { 51, 67},
            { 71, 91},
            { 78, 98},
            { 87, 94}
        };
            Snakes = new Dictionary<int, int> {
            { 16, 6 },
            { 46, 25},
            { 49, 11},
            { 62, 19},
            { 64, 60},
            { 74, 53},
            { 89, 68},
            { 92, 88},
            { 95, 75},
            { 99, 80}
        };
        }
        public int[] Squares { get; set; }
        public Dictionary<int, int> Ladders { get; set; }
        public Dictionary<int, int> Snakes { get; set; }
    };
}
