using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ratepokerhands
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new PokerHand("KS 2H 5C JD TD").CompareWith(new PokerHand("opponent")));
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
            //Result result;

            //if (Hand > hand)
            //{
            //    result = Result.Win;
            //}
            //else if(Hand < hand)
            //{
            //    result = Result.Loss;
            //}
            //else
            //{
            //    result = Result.Tie;
            //}


            switch (CompareHands(Hand, hand.Hand))
            {
                case Result.Win:
                    return Result.Win;
                case Result.Loss:
                    return Result.Loss;
                default:
                    return Result.Tie;
            }
        }

        private Result CompareHands(string hand1, string hand2)
        {
            var firstHand = hand1.Split();
            var secondHand = hand2.Split();

            var tmp = new string[][] { firstHand, secondHand };

            for (int i = 0; i < 5; i++)
            {
                foreach (var item in tmp)
                {
                    switch (item[i][0])
                    {
                        case 'A': item[i] = "14" + item[i].Substring(1); break;
                        case 'K': item[i] = "13" + item[i].Substring(1); break;
                        case 'Q': item[i] = "12" + item[i].Substring(1); break;
                        case 'J': item[i] = "11" + item[i].Substring(1); break;
                        case 'T': item[i] = "10" + item[i].Substring(1); break;
                        default:
                            break;
                    }
                }
            }

            return Result.Loss;
        }
    }
}
