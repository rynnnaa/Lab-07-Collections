using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab_07_Collections.Classes
{
    public class Deck<T> : IEnumerable<T> where T : Card
    {
         T[] cards = new T[56];
        int currentIndex = 0;

        int counter = 0;
        public void Add(T item)
        {
            if (currentIndex > cards.Length - 1)
            {
                Array.Resize(ref cards, cards.Length * 3);
            }
            cards[currentIndex] = item;
            currentIndex++;
            counter++;

        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < currentIndex; i++)
            {
                yield return cards[i];
            }
        }










        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
