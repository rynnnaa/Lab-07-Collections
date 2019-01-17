using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_07_Collections.Classes
{
    public class Card
    {
        public string cardNum { get; set; }
        public CardSuit CardSuit { get; set; }

        public enum Suits { Heart, Diamond, Club, Spade }


        public Card(string cardN, CardSuit cardsuit)
        {
            cardNum = cardN;
            cardsuit = CardSuit;
        }

    }
}