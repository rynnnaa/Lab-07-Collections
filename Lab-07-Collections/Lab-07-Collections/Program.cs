using Lab_07_Collections.Classes;
using System;

namespace Lab_07_Collections
{
    public class Program
    {
        public static object Deck { get; set; }
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
