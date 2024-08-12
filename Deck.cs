using System;
using System.Collections.Generic;
using System.Linq;

public class Deck
{
    private List<Card> cards;
    private static readonly string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
    private static readonly string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
    private static readonly int[] values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };

    public Deck()
    {
        cards = new List<Card>();

        for (int i = 0; i < suits.Length; i++)
        {
            for (int j = 0; j < ranks.Length; j++)
            {
                cards.Add(new Card(suits[i], ranks[j], values[j]));
            }
        }

        Shuffle();
    }

    public void Shuffle()
    {
        Random rng = new Random();
        cards = cards.OrderBy(a => rng.Next()).ToList();
    }

    public Card DrawCard()
    {
        if (cards.Count == 0) return null;
        Card card = cards[0];
        cards.RemoveAt(0);
        return card;
    }
}
