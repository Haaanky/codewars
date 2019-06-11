using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x = new string[1];
            Kata.IsValidWalk(x);
        }
    }
    public class Kata
    {
        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length != 10)
                return false;
            var player = new Position(0, 0);

            foreach (var item in walk)
            {
                switch (item)
                {
                    case "n":
                        player.Y += 1;
                        break;
                    case "s":
                        player.Y -= 1;
                        break;
                    case "w":
                        player.X += 1;
                        break;
                    case "e":
                        player.X -= 1;
                        break;
                    default:
                        break;
                }
            }
            return (player.X == 0 && player.Y == 0) ? true : false;
        }
    }

    internal class Position
    {
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
