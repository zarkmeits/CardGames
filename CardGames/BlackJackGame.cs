using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames
{
    class BlackJackGame
    {
        static Deck d = new Deck();
        static BlackJackHand h1;
        static BlackJackHand h2;
        static bool won = false;

        static BlackJackGame()
        {
            // call six times to make the deck the proper size
            for(int i = 0; i < 6; i++)
            {
                CreateDeck(d);
            }

            // shuffle deck
            d.Shuffle();

            h1 = new BlackJackHand();
            for (int j = 0; j < 2; j++)
            {
               h1.AddCard(d.DealOne());
            }

            h2 = new BlackJackHand();
            for (int j = 0; j < 2; j++)
            {
                h2.AddCard(d.DealOne());
            }
        }

        public static void CreateDeck(Deck d)
        {
            for (int x = 0; x < Suit.VALUES.Count; x++)
            {
                for (int y = 0; y < Rank.VALUES.Count; y++)
                {
                    Card card = new CardGames.Card(Suit.VALUES[x], Rank.VALUES[y]);
                    d.AddCard(card);
                }
            }
        }

        public static string TheEnd(int i)
        {
            //if the player exceeds 21
            if(i == 1)
            {
                won = true;
                return "Player has exceeded 21. Computer Wins.";
            }
            // if the computer has the higher hand
            else if(i == 2)
            {
                won = true;

                return "The Computer Wins!";
            }
            // if the player has the higher hand
            else if (i == 3)
            {
                won = true;
                return "The Player Wins!";
            }
            else if(i == 4)
            {
                won = true;
                return "Computer has exceeded 21. Player Wins.";
            }
            else
            {
                won = true;
                return null;
            }
        }

        public static void PlayGame()
        {

            int response;

            Console.WriteLine("Welcome To Blackjack!");
            Console.WriteLine("Hand 1 -> Player \nHand 2 -> Computer");
            Console.WriteLine("Hand 1: " + h1 + h1.EvaluateHand());
            Console.WriteLine("Hand 2: " + h2 + h2.EvaluateHand());


            // Just to see if anyone wins right away!
            if (h1.EvaluateHand() == 21)
            {
                Console.WriteLine("Player Wins");
            }
            else if(h2.EvaluateHand() == 21)
            {
                Console.WriteLine("Computer Wins");
            }
            else if(h1.EvaluateHand() == 21 && h2.EvaluateHand() == 21)
            {
                Console.WriteLine("Tie!");
            }

            //Player Turn Starts Here!
            do
            {
                Console.WriteLine("Please either hit (1) or stand (2).");
                response = Int32.Parse(Console.ReadLine());

                if (response == 2)
                    break;

                h1.AddCard(d.DealOne());
                Console.WriteLine("Hand 1: " + h1 + h1.EvaluateHand());
                Console.WriteLine("Hand 2: " + h2 + h2.EvaluateHand());

                if(h1.EvaluateHand() > 21)
                {
                    Console.WriteLine(TheEnd(1));
                    break;
                }
                else if(h1.EvaluateHand() == 21)
                {
                    Console.WriteLine(TheEnd(3));
                    break;
                }
            } while (response == 1);

            if(won == false)
            {
                // ====== computer turn =====
                do
                {
                    Console.WriteLine("Computer's Turn");
                    if (h2.CompareTo(h1) == 1)
                    {
                        Console.WriteLine(TheEnd(2));
                        break;
                    }

                    // add new card to hand and display
                    h2.AddCard(d.DealOne());
                    Console.WriteLine("Hand 1: " + h1 + h1.EvaluateHand());
                    Console.WriteLine("Hand 2: " + h2 + h2.EvaluateHand());

                    if(h2.EvaluateHand() == 21)
                    {
                        Console.WriteLine(TheEnd(2));
                        break;
                    }
                    else if(h2.EvaluateHand() > 21)
                    {
                        Console.WriteLine(TheEnd(4));
                        break;
                    }

                } while (h2.EvaluateHand() <= 21);
            }
        }
    }
}
