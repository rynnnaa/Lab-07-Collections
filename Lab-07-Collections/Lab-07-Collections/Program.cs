﻿using Lab_07_Collections.Classes;
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

            Card card3 = new Card();
            card3.Value = Card.CardValue.Three;
            card3.suit = Card.Suit.Hearts;

            Card card4 = new Card();
            card4.Value = Card.CardValue.Four;
            card4.suit = Card.Suit.Spades;

            Card card5 = new Card();
            card5.Value = Card.CardValue.Five;
            card5.suit = Card.Suit.Diamonds;

            Card card6 = new Card();
            card6.Value = Card.CardValue.Six;
            card6.suit = Card.Suit.Hearts;

            Card card7 = new Card();
            card7.Value = Card.CardValue.Seven;
            card7.suit = Card.Suit.Clubs;

            Card card8 = new Card();
            card8.Value = Card.CardValue.Eight;
            card8.suit = Card.Suit.Diamonds;

            Card card9 = new Card();
            card9.Value = Card.CardValue.Nine;
            card9.suit = Card.Suit.Spades;

            Card card10 = new Card();
            card10.Value = Card.CardValue.Ten;
            card10.suit = Card.Suit.Hearts;

            Card card11 = new Card();
            card11.Value = Card.CardValue.Jack;
            card11.suit = Card.Suit.Spades;

            Card card12 = new Card();
            card12.Value = Card.CardValue.Queen;
            card12.suit = Card.Suit.Clubs;

            Card card13 = new Card();
            card13.Value = Card.CardValue.King;
            card13.suit = Card.Suit.Diamonds;

            //add cards to the deck
            Deck.Add(card1);
            Deck.Add(card2);
            Deck.Add(card3);
            Deck.Add(card4);
            Deck.Add(card5);
            Deck.Add(card6);
            Deck.Add(card7);
            Deck.Add(card8);
            Deck.Add(card9);
            Deck.Add(card10);
            Deck.Add(card11);
            Deck.Add(card12);
            Deck.Add(card13);

            foreach (Card item in Deck)
            {
                Console.WriteLine($"{item.Value} of {item.suit}");
            }

            //deal cards evenly between player 1 and player 2
            Console.WriteLine("");
            Console.WriteLine("Deal cards:");
            Console.WriteLine("");

            int counter = 0;

            foreach (Card item in Deck)
            {
                counter++;
                if (counter < 7)
                {
                    Console.WriteLine($"Player 1 cards: {item.Value} of {item.suit}");
                }
                else if (counter >= 7 && counter < 13)
                {
                    Console.WriteLine($"Player 2 cards: {item.Value} of {item.suit}");
                }
                else
                {
                    Console.WriteLine($"Dealer cards:  {item.Value} of {item.suit}");
                }
            }

            //Remove one card from the deck
            Console.WriteLine("");

            //card can only be removed if it actually exists in the deck
            Card removefromdeck = Deck.Remove(card3);
            if (removefromdeck != null)
            {
                Console.WriteLine($"Removing {removefromdeck.Value} of {removefromdeck.suit}");

            }

            //show deck counter after remove

            Console.WriteLine("");
            Console.WriteLine($"Number of cards left: {Deck.Count()}");
            Console.WriteLine("");

            //show leftover cards
            foreach (Card item in Deck)
            {
                Console.WriteLine($"{item.Value} of {item.suit}");
            }

        }
    }
}
