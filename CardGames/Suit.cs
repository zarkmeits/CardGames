using System;
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

        static int CLUBS = 1;
        static int DIAMONDS = 2;
        static int HEARTS = 3;
        static int SPADES = 4;

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

        //Are GetSymbal and GetName and ToString the same thing? 
        //
        //Or should we do this?
        public char GetSymbol()
        {
            switch (this.suit)
            {
                case 1:
                    return '♣';
                case 2:
                    return '♦';
                case 3:
                    return '♥';
                case 4:
                    return '♠';
                default:
                    return 'x';
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
    }
}