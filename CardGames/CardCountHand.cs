using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames 
{
    class CardCountHand : Hand
    {
        public override int CompareTo(Hand OtherHandObject)
        {
            int handOneVal = this.EvaluateHand();
            int handTwoVal = OtherHandObject.EvaluateHand();    
                    
            if(handOneVal > handTwoVal)
            {
                return 1;
            } 
            else if (handOneVal < handTwoVal)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        override public int EvaluateHand()
        {
            int totalValue = 0;
            
            for (var i = 0; i < this.GetNumberOfCards(); i++)
            {
                Card temp = this.GetCardAtIndex(i);
                int value = GetCardValue(temp);
                totalValue += value;
            }

            return totalValue;
        }

        public static int GetCardValue(Card c)
        {
            int pts = 0;
            Rank r = c.GetRank();

            if(r.rank <= 10)
            {
                pts = r.rank;
            }
            else if(r.rank < 14)
            {
                pts = 10;
            }
            else
            {
                pts = 1;
            }

            return pts;
       }
    }
}
