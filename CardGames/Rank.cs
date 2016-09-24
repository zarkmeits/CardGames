using System;
using System.Collections.Generic;

namespace CardGames
{
    public class Rank
    {
        int rank;

        public static List<Rank> VALUES = new List<Rank>();

        static readonly Rank TWO;
        static readonly Rank THREE;
        static readonly Rank FOUR;
        static readonly Rank FIVE;
        static readonly Rank SIX;
        static readonly Rank SEVEN;
        static readonly Rank EIGHT;
        static readonly Rank NINE;
        static readonly Rank TEN;
        static readonly Rank JACK;
        static readonly Rank QUEEN;
        static readonly Rank KING;
        static readonly Rank ACE;

        static Rank()
        {
            TWO = new Rank(2);
            THREE = new Rank(3);
            FOUR = new Rank(4);
            FIVE = new Rank(5);
            SIX = new Rank(6);
            SEVEN = new Rank(7);
            EIGHT = new Rank(8);
            NINE = new Rank(9);
            TEN = new Rank(10);
            JACK = new Rank(11);
            QUEEN = new Rank(12);
            KING = new Rank(13);
            ACE = new Rank(14);

            VALUES.Add(TWO);
            VALUES.Add(THREE);
            VALUES.Add(FOUR);
            VALUES.Add(FIVE);
            VALUES.Add(SIX);
            VALUES.Add(SEVEN);
            VALUES.Add(EIGHT);
            VALUES.Add(NINE);
            VALUES.Add(TEN);
            VALUES.Add(JACK);
            VALUES.Add(QUEEN);
            VALUES.Add(KING);
            VALUES.Add(ACE);
        }

        public Rank(int val)
        {
            rank = val;
        }

        public int CompareTo(Rank OtherRankObject)
        {
            if (this.rank == OtherRankObject.rank)
            {
                return 0;
            }
            else if (this.rank < OtherRankObject.rank)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        public string GetSymbol()
        {
            switch (this.rank)
            {
                case 2:
                    return "2";
                case 3:
                    return "3";
                case 4:
                    return "4";
                case 5:
                    return "5";
                case 6:
                    return "6";
                case 7:
                    return "7";
                case 8:
                    return "8";
                case 9:
                    return "9";
                case 10:
                    return "10";
                case 11:
                    return "J";
                case 12:
                    return "Q";
                case 13:
                    return "K";
                case 14:
                    return "A";
                default:
                    return "Invalid.";
            }
        }

        public string GetName()
        {
            switch(this.rank)
            {
                case 2:
                    return "TWO";
                case 3:
                    return "THREE";
                case 4:
                    return "FOUR";
                case 5:
                    return "FIVE";
                case 6:
                    return "SIX";
                case 7:
                    return "SEVEN";
                case 8:
                    return "EIGHT";
                case 9:
                    return "NINE";
                case 10:
                    return "TEN";
                case 11:
                    return "JACK";
                case 12:
                    return "QUEEN";
                case 13:
                    return "KING";
                case 14:
                    return "ACE";
                default:
                    return "invalid.";
            }    
        }

        public override string ToString()
        {
            // WHAT ARE WE DOING!
            return this.GetName();
        }

        static void Main()
        {
            List<Rank> ranks = new List<Rank>();

            foreach (Rank card in ranks)
            {
                Console.WriteLine(card.rank);
            }
        }
    }
}