using System;
using System.Collections.Generic;

namespace CardPower
{
    public class StartUp
    {
        public static void Main()
        {

        }

        public static void GenerateDeckOfCards()
        {
            var deck = new List<Card>();

            foreach (var suit in Enum.GetNames(typeof(Suit)))
            {
                foreach (var rank in Enum.GetNames(typeof(Rank)))
                {
                    deck.Add(new Card(rank, suit));
                }
            }

            foreach (var card in deck)
            {
                Console.WriteLine(card.Name);
            }
        }

        public static void PrintAttribute()
        {
            var input = Console.ReadLine();
            Type type = input == "Rank" ? type = typeof(Rank) : type = typeof(Suit);
            var attributes = type.GetCustomAttributes(false);
            Console.WriteLine(attributes[0]);
        }

        public static void CardCompareTo()
        {
            var cardRank =  Console.ReadLine();
            var cardSuit = Console.ReadLine();
            var card = new Card(cardRank, cardSuit);
            var secondCardRank = Console.ReadLine();
            var secondCardSuit = Console.ReadLine();
            var secondCard = new Card(secondCardRank, secondCardSuit);

            var result = card.CompareTo(secondCard);

            Console.WriteLine(result == 1 ? card : secondCard);
        }
    }
}
