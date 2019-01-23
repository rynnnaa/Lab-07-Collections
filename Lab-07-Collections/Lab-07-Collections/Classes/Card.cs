using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_07_Collections.Classes
{
    public class Card
    {
        public Suit CardSuit { get; set; }
        public CardValue Value { get; set; }
        public Suit suit { get; set; }

        public enum Suits { Heart, Diamond, Club, Spade }


        public Card(string cardN, CardSuit cardsuit)
        {
            cardNum = cardN;
            cardsuit = CardSuit;
        }

    }
}