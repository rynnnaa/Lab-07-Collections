using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_07_Collections.Classes
{
    class Deck
    {
        public string cardNum { get; set; }
        public CardSuit CardSuit { get; set; }

        public enum Suits { Heart, Diamond, Club, Spade }
    }

}
