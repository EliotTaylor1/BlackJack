using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Card
    {
        public enum Rank
        {
            Rank_2,
            Rank_3,
            Rank_4,
            Rank_5,
            Rank_6,
            Rank_7,
            Rank_8,
            Rank_9,
            Rank_10,
            Rank_Jack,
            Rank_Queen,
            Rank_King,
            Rank_Ace
        }
        public enum Suit
        {
            Suit_Club,
            Suit_Spade,
            Suit_Heart,
            Suit_Diamond
        }
        public Card(Rank rank, Suit suit)
        {
            _rank = rank;
            _suit = suit;
         }
        public Rank _rank;
        public Suit _suit;

        public string PrintCard()
        {
            string cardRank = _rank switch
            {
                Rank.Rank_2 => "2",
                Rank.Rank_3 => "3",
                Rank.Rank_4 => "4",
                Rank.Rank_5 => "5",
                Rank.Rank_6 => "6",
                Rank.Rank_7 => "7",
                Rank.Rank_8 => "8",
                Rank.Rank_9 => "9",
                Rank.Rank_10 => "10",
                Rank.Rank_Jack => "J",
                Rank.Rank_Queen => "Q",
                Rank.Rank_King => "K",
                Rank.Rank_Ace => "A",
                _ => "Unknown",
            };
            string cardSuit = _suit switch
            {
                Suit.Suit_Club => "C",
                Suit.Suit_Spade => "S",
                Suit.Suit_Heart => "H",
                Suit.Suit_Diamond => "D",
                _ => "Unknown",
            };
            string card = cardRank + cardSuit;
            return card;
        }
        public int GetCardValue()
        {
            return _rank switch
            {
                Rank.Rank_2 => 2,
                Rank.Rank_3 => 3,
                Rank.Rank_4 => 4,
                Rank.Rank_5 => 5,
                Rank.Rank_6 => 6,
                Rank.Rank_7 => 7,
                Rank.Rank_8 => 8,
                Rank.Rank_9 => 9,
                Rank.Rank_10 => 10,
                Rank.Rank_Jack => 10,
                Rank.Rank_Queen => 10,
                Rank.Rank_King => 10,
                Rank.Rank_Ace => 11,
                _ => 0,
            };
        }
        public override string ToString()
        {
            return PrintCard();
        }
    }
}
