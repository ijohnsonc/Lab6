ususing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hand
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();
    }

   public int NumCards
    {
        get
        {
            return cards.Count;
        }
    }
    class CardCompare : IComparer<Card>
    {
        public int Compare(Card? x, Card? y)
        {
            if (x.Value > y.Value)
                return 1;
            if (x.Value < y.Value)
                return -1;
            if (x.Suit > y.Suit)
                return 1;
            if (x.Suit < y.Suit)
                return -1;
            return 0;
        }
    }
    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }
        public string Name
        {
            get
            {
                return Value.ToString() + " of " + Suit.ToString();
            }
        }
    }
    enum Suits
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts,
    }
    enum Values
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack=10,
        Queen=11,
        King=12,
    }
}

public override string ToString()
    {
        string output = "";
        // go through every card in the deck
        foreach (Card c in cards)
            // ask the card to convert itself to a string
            output += (c.ToString() + "\n");
        return output;
    }
}