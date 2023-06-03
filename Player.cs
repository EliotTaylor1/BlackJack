using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Player
    {
        string playerName;
        List<Card> hand;
        int handValue;
        bool isBust;

        public Player(string playerName)
        {
            this.playerName = playerName;
            if(hand == null)
            {
                hand = new List<Card>();
            }
        }

        public void DrawCard(Deck deck)
        {
            hand.Add(deck.deck[deck.DeckIndex]);
            deck.DeckIndex++;
        }

        public void PrintHand()
        {
            Console.WriteLine($"{playerName}'s hand: ");
            foreach (var card in hand)
            {
                Console.WriteLine(card);
            }

        }

        /*public void GetHandValue()
        {
            
            foreach (var card in hand)
            {
                handValue += getCardValue(card);
            }
            
        }*/
    }
}
