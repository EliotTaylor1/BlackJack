using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Deck
    {
        public int DeckIndex { get; set; } = 0;
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
            Console.WriteLine("");
        }
        public void ShuffleDeck()
        {
            Console.WriteLine("\nShuffling deck");
            Random random = new Random();

            for (int i = deck.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Card temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }
    }
}
