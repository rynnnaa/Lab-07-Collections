using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_07_Collections.Classes
{
    public class Card
    {
        //properties
        public Suit CardSuit { get; set; }
        public CardValue Value { get; set; }
        public Suit suit { get; set; }

        //card construrctor
        public Card(CardValue value, Suit suit)
        {
            Value = value;
            CardSuit = suit;
        }

        public Card()
        {

        }
        //enum acts as a class within the card class!
        public enum Suit
        {
            Hearts,
            Spades, 
            Diamonds,
            Clubs

        }


    }
}