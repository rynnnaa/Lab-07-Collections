using Lab_07_Collections.Classes;
using System;

namespace Lab_07_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Deck<Card> Deck = new Deck<Card>();



            foreach (Card item in Deck)
            {
                Console.Write($"{item.cardNum} {item.cardsuit}");
                
            }
            
        }
    }
}
