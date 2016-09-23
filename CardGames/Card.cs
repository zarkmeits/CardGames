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
            if (this.rank == OtherCardObject.rank)
            {
                return 0;
            }
            else if ((this.rank) < OtherCardObject.rank)
            {
                return -1;   
            }
        }
    }
}
