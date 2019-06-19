using System;

namespace ratepokerhands
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public enum Result
    {
        Win,
        Loss,
        Tie
    }

    public class PokerHand
    {
        public PokerHand(string hand)
        {
            Hand = hand;
        }

        public string Hand { get; }

        public Result CompareWith(PokerHand hand)
        {
            return Result.Tie;
        }
    }
}
