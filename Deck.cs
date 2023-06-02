using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Deck
    {
        public int deckIndex;
        public List<Card> deck;

        public Deck() 
        {
            deck = new List<Card>();

            foreach (Card.Rank rank in Enum.GetValues(typeof(Card.Rank)))
            {
                foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
                {
                    Card card = new(rank, suit);
                    deck.Add(card);
                }
            }
        }
        public void PrintDeck()
        {
            foreach (Card card in deck)
            {
                Console.Write($"{card}, ");
            }
        }
    }
}
