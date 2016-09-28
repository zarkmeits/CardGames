using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames
{
    abstract class Hand
    {
        public List<Card> handOfCards = new List<Card>();

        public void AddCard(Card c)
        {
            handOfCards.Add(c);
        }

        abstract public int CompareTo(Hand OtherHandObject);

        public bool ContainsCard(Card c)
        {
            if (this.ContainsCard(c))
            {
                return true;
            }    
            else
            {
                return false;
            }
        }

        public void DiscardHand()
        {
            foreach(Card c in handOfCards)
            {
                handOfCards.Remove(c);
            }
        }

        public int FindCard(Card c)
        {
            return handOfCards.IndexOf(c);    
        }

        public Card GetCardAtIndex(int index)
        {
            return handOfCards[index];
        }

        public int GetNumberOfCards()
        {
            return handOfCards.Count;
        }

        public bool IsEmpty()
        {
            if(handOfCards.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Card RemoveCard(Card c)
        {
            int pos = handOfCards.IndexOf(c);
            Card removedCard = handOfCards[pos];
            handOfCards.RemoveAt(pos);

            return removedCard;
        }

        public Card RemoveCard(int pos)
        {
            Card removedCard = handOfCards[pos];
            handOfCards.RemoveAt(pos);

            return removedCard;
        }

        abstract public int EvaluateHand();

        public override string ToString()
        {
            string message = "";

            foreach(Card c in handOfCards)
            {
                message += c + " ";
            }

            return message;
        }
    }
}
