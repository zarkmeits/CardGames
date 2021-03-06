﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames
{
    class Suit
    {

        int suit;

        // static int Values = 1; WHAT IS THIS SUPPOSED TO BE

        public static readonly Suit CLUBS;
        public static readonly Suit DIAMONDS;
        public static readonly Suit HEARTS;
        public static readonly Suit SPADES;

        public static List<Suit> VALUES;

        static Suit()
        {
            CLUBS = new Suit(1);
            DIAMONDS = new Suit(2);
            HEARTS = new Suit(3);
            SPADES = new Suit(4);

            VALUES = new List<Suit>()
            {
                CLUBS,
                DIAMONDS,
                HEARTS,
                SPADES,
            };
        }

        public Suit(int suitValue)
        {
            this.suit = suitValue;
        }

        public int CompareTo(Suit OtherSuitObject)
        {
            if (this.suit == OtherSuitObject.suit)
            {
                return 0;
            }
            else if (this.suit < OtherSuitObject.suit)
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
            switch (this.suit)
            {
                case 1:
                    return "♣";
                case 2:
                    return "♦";
                case 3:
                    return "♥";
                case 4:
                    return "♠";
                default:
                    return "x";
            }
        }

        public string GetName()
        {
            switch (this.suit)
            {
                case 1:
                    return "CLUBS";
                case 2:
                    return "DIAMONDS";
                case 3:
                    return "HEARTS";
                case 4:
                    return "SPADES";
                default:
                    return "Invalid.";
            }
        }

        public override string ToString()
        {
            // WHAT ARE WE DOING!
            return this.GetSymbol();
        }
    }
}