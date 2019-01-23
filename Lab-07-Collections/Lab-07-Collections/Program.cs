using Lab_07_Collections.Classes;
using System;

namespace Lab_07_Collections
{
    public class Program
    {
        public static object Deck { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Cards In Deck:");
            Console.WriteLine("");

            //set up deck 

            Deck<Card> Deck = new Deck<Card>();

            Card card1 = new Card();
            card1.Value = Card.CardValue.Ace;
            card1.suit = Card.Suit.Clubs;

            Card card2 = new Card();
            card2.Value = Card.CardValue.Two;
            card2.suit = Card.Suit.Diamonds;





            
        }
    }
}
