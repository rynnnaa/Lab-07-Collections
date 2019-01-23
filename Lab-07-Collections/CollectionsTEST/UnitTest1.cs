using System;
using Xunit;
using Lab_07_Collections.Classes;

namespace CollectionsTEST
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddCard()
        {
            Card card1 = new Card();
            card1.Value = Card.CardValue.Jack;
            card1.CardSuit = Card.Suit.Spades;

            Deck<Card> Deck = new Deck<Card>();
            Deck.Add(card1);

            Assert.Contains(card1, Deck);


        }

        [Fact]
        public void GetSetTest()
        {
            Card card2 = new Card();
            card2.Value = Card.CardValue.Two;
            card2.CardSuit = Card.Suit.Diamonds;
            var Diamonds = card2.suit;

            Deck<Card> Deck = new Deck<Card>();
            Deck.Add(card2);

            Assert.Equal(Diamonds, card2.suit);
        }

        [Fact]
        public void RemoveCardTest()
        {
            Card card3 = new Card();
            card3.Value = Card.CardValue.Three;
            card3.suit = Card.Suit.Hearts;

            Card card4 = new Card();
            card4.Value = Card.CardValue.Four;
            card4.suit = Card.Suit.Spades;

            Deck<Card> Deck = new Deck<Card>();
            Deck.Add(card3);
            Deck.Add(card4);

            Deck.Remove(card4);

            Assert.DoesNotContain(card4, Deck);
        }
    }
}
