using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames
{
    class Deck
    {

        int cardTotal;

        public static List<Card> DECK;
        public static List<Card> dealt;

        public Deck()
        {
            DECK = new List<Card>();   
            dealt = new List<Card>();
        }

        public void AddCard(Card c)
        {
            DECK.Add(c);    
        }

        public Card DealOne()
        {
            Card c = DECK[0];
            dealt.Add(c);
            DECK.RemoveAt(0);
            return c;
        }

        public int GetCardsRemaining()
        {
            return DECK.Count;
        }

        public int GetDeckSize()
        {
            return (DECK.Count + dealt.Count);
        }

        public bool isEmpty()
        {
            if (DECK.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Shuffle()
        {
            Random r = new Random();

            for (int i = 0; i < DECK.Count; i++)
            {
                int rand = r.Next(0, DECK.Count);
                Card temp = DECK[i];

                DECK[i] = DECK[rand];
                DECK[rand] = temp; 
            }
        }

        public void RestoreDeck()
        {
            foreach(Card c in dealt)
            {
                DECK.Add(c);
            }
        }
    }
}
