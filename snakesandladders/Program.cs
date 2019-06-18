using System;
using System.Collections.Generic;
using System.Linq;

namespace snakesandladders
{
    class Program
    {
        static void Main(string[] args)
        {
            SnakesLadders game = new SnakesLadders();
            Console.WriteLine(game.play(1, 1));
            Console.WriteLine(game.play(6, 2));
            Console.WriteLine(game.play(1, 2));
            Console.WriteLine(game.play(1, 2));
            Console.WriteLine(game.play(1, 2));
        }
    }
    class SnakesLadders
    {
        private GameBoard gameBoard;
        private int round = 1;
        public SnakesLadders()
        {
            gameBoard = new GameBoard(100) { Players = { new Player(0, 1), new Player(0, 2) } };
        }
        public string play(int die1, int die2)
        {
            var gameboardSize = gameBoard.Squares.Count;

            if (gameBoard.Players.Any(x => x.Location == gameboardSize))
                return "Game over!";

            gameBoard.CurrentPlayer = round % 2 != 0 ? gameBoard.Players[0] : gameBoard.Players[1];
            var playerLocation = gameBoard.CurrentPlayer.Location += die1 + die2;

            if (playerLocation == gameboardSize)
                return $"{gameBoard.CurrentPlayer} Wins!";

            if (playerLocation > gameboardSize)
                gameBoard.CurrentPlayer.Location = gameboardSize - (playerLocation - gameboardSize);

            gameBoard.CurrentPlayer.Location = gameBoard.Squares[gameBoard.CurrentPlayer.Location];

            if (die1 != die2)
                round++;

            return $"{gameBoard.CurrentPlayer} is on square {gameBoard.CurrentPlayer.Location}";
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
        public override string ToString()
        {
            return $"Player {ID}";
        }
    }

    internal class GameBoard
    {
        public GameBoard(int squares)
        {
            Squares = new Dictionary<int, int>(squares) {
                { 16, 6 }, { 46, 25 }, { 49, 11 },
                { 62, 19 }, { 64, 60 }, { 74, 53 },
                { 89, 68 }, { 92, 88 }, { 95, 75 },
                { 99, 80 }, { 2, 38 }, { 7, 14 },
                { 8, 31 },
                { 15, 26 }, { 21, 42 }, { 28, 84 },
                { 36, 44 }, { 51, 67 }, { 71, 91 },
                { 78, 98 }, { 87, 94 }
            };

            for (int i = 0; i < squares; i++)
            {
                Squares.TryAdd(i, i);
            }
        }
        public Dictionary<int, int> Squares { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();
        public Player CurrentPlayer { get; set; }
    }
}
