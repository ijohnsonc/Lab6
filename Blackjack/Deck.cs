using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
    public class Deck
    {
        
        private List<Card> cards = new List<Card>();
        

        public Deck()
        {
            
            for (int value = 1; value <= 13; value++)
                
                for (int suit = 1; suit <= 4; suit++)
                    
                    cards.Add(new Card(value, suit));
        }
        public List<PlayingCard> CreateDeckOfCards()
        {
            // Create a new empty collection of playing cards
            List<PlayingCard> deckOfCards = new List<PlayingCard>();

            string cardsuitlabel = string.Empty;
            string cardvaluelabel = string.Empty;

            // Loop for each suit and assign the suit
            for (int cardsuit = 0; cardsuit <= Suits - 1; cardsuit++)
            {
                cardsuitlabel = string.Empty;

                switch (cardsuit)
                {
                    case 0:
                        cardsuitlabel = "H"; 
                        break;

                    case 1:
                        cardsuitlabel = "D"; 
                        break;

                    case 2:
                        cardsuitlabel = "C"; 
                        break;

                    case 3:
                        cardsuitlabel = "S"; 
                        break;

                    default:
                        break;
                }
                for (int cardsuit = 0; cardsuit <= Suits - 1; cardsuit++)
                {
                    cardsuitlabel = string.Empty;

                    switch (cardsuit)
                    {
                        case 0:
                            cardsuitlabel = "H"; // Hearts
                            break;

                        case 1:
                            cardsuitlabel = "D"; // Diamonds
                            break;

                        case 2:
                            cardsuitlabel = "C"; // clubs
                            break;

                        case 3:
                            cardsuitlabel = "S"; // Spades
                            break;

                        default:
                            break;
                    }

                    // Loop for each card and create the card in the suit.
                    for (int cardvalue = 1; cardvalue <= CardsInSuit; cardvalue++)
                    {
                        cardvaluelabel = string.Empty;

                        // Instantiate the new playing card
                        PlayingCard mycard = new PlayingCard();

                        // Assign the value of the card
                        switch (cardvalue)
                        {
                            case 1:
                                cardvaluelabel = "A"; 
                                break;

                            case 11:
                                cardvaluelabel = "J"; 
                                break;

                            case 12:
                                cardvaluelabel = "Q"; 
                                break;

                            case 13:
                                cardvaluelabel = "K"; 
                                break;

                            default:
                                cardvaluelabel = cardvalue.ToString(); 
                                break;
                        }

                        mycard.CardSuit = cardsuitlabel;
                        mycard.CardValue = cardvaluelabel;
                        mycard.CardPlayed = false;

                      
                        deckOfCards.Add(mycard);
                    }
                }

        public int NumCards
        {
            get
            {
                return cards.Count;
            }
        }


        public bool IsEmpty
        {
            get
            {
                return (cards.Count == 0);
            }
        }

        public Card this[int i]
        {
            get
            {
                return cards[i];
            }
        }

        // dealing from the deck should return a card object
        public Card Deal()
        {
            
            if (!IsEmpty)
            {
                
                Card c = cards[0];
                
                cards.Remove(c);
                // return the first card
                return c;
            }
            // when the deck is empty, return null or throw an exception
            return null;
        }

       

        public void Shuffle()
        {
            Random gen = new Random();
            // go through all of the cards in the deck
            for (int i = 0; i < NumCards; i++)
            {
                // generate a random index
                int rnd = gen.Next(0, NumCards);
                // swap the card at the random index with the card at the current index
                Card c = cards[rnd];
                cards[rnd] = cards[i];
                cards[i] = c;
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
}
