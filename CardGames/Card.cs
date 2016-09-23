using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames
{
    class Card
    {
        Suit suit;
        Rank rank;

        public Card(Suit s, Rank r)
        {
            this.suit = s;
            this.rank = r;
        }

        public int CompareTo(Card OtherCardObject)
        {
            if (this.rank.CompareTo(OtherCardObject.rank) == 0)
            {
                return 0;
            }
            else if (this.rank.CompareTo(OtherCardObject.rank) == -1)
            {
                return -1;   
            }
            else
            {
                return 1;
            }
        }

        public Rank GetRank()
        {
            return this.rank;
        }

        public Suit GetSuit()
        {
            return this.suit;
        }

        public override string ToString()
        {
            return (this.rank + " of " + this.suit);
        }
    }
}
