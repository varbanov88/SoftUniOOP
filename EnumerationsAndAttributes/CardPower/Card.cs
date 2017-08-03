using System;

namespace CardPower
{
    public class Card : IComparable<Card>
    {
        public Card(string rank, string suit)
        {
            this.Rank = (Rank)Enum.Parse(typeof(Rank), rank);
            this.Suit = (Suit)Enum.Parse(typeof(Suit), suit);
            this.Power = (int)this.Rank + (int)this.Suit;
        }

        public Rank Rank { get; set; }

        public Suit Suit { get; set; }

        public string Name => $"{this.Rank} of {this.Suit}";

        public int Power { get; private set; }

        public int CompareTo(Card other)
        {
            return this.Power.CompareTo(other.Power);
        }

        public override string ToString()
        {
            return $"Card name: {this.Name}; Card power: {Power}";
        }
    }
}