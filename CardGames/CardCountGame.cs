using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames
{
    class CardCountGame
    {
        static Deck d = new Deck();
        static CardCountHand h1;
        static CardCountHand h2;
        
        static CardCountGame()
        {
            CreateDeck(d);
            d.Shuffle();

            h1 = new CardCountHand();
            for (int j = 0; j < 8; j++)
            {
                h1.AddCard(d.DealOne());
            }

            h2 = new CardCountHand();
            for (int j = 0; j < 8; j++)
            {
                h2.AddCard(d.DealOne());
            }
        }

        public static void CreateDeck(Deck d)
        {
            for (int x = 0; x < Suit.VALUES.Count; x++)
            {
                for(int y = 0; y < Rank.VALUES.Count; y++)
                {
                    Card card = new CardGames.Card(Suit.VALUES[x], Rank.VALUES[y]);
                    d.AddCard(card);
                }
            }
        }

        public static void PlayGame()
        {
            Console.WriteLine("Hand 1: " + h1);
            Console.WriteLine("Hand 2: " + h2);
            Console.WriteLine("Hand 1 Score: " + h1.EvaluateHand());
            Console.WriteLine("Hand 2 Score: " + h2.EvaluateHand());
            Console.WriteLine("Card Remaining In Deck: " + d.GetCardsRemaining());
        }
    }
}
