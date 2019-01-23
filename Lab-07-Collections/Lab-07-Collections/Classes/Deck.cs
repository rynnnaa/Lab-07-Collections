using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_07_Collections.Classes
{
     class Deck<T> : IEnumerable<T>
    {
        public T[] cards = new T[13];
        int currentIndex = 0;

        //adding a card to the deck

        public void Add(T item)
        {
            if (currentIndex == cards.Length)
            {
                Array.Resize(ref cards, cards.Length * 2);
            }
            cards[currentIndex] = item;
            currentIndex++;

        }

        //remove card from deck

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                yield return cards[i];
            }
        }

        public T Remove (T item)
        {
            T deletedCard = default(T);


            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i].Equals(item))
                {
                    deletedCard = cards[i];
                    while (i < currentIndex - 1)
                    {
                        //reset
                        cards[i] = cards[i + 1];
                        i++;
                    }
                    cards[i] = default(T);

                    currentIndex--;
                    return deletedCard;

                }
            }

            throw new Exception("card does not exists in the deck");
        }

       //count cards in deck

        public int Count()
    }

}
