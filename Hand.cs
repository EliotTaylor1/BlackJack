using System.Collections.Generic;

public class Hand
{
    public List<Card> Cards { get; private set; }
    public int TotalValue { get; private set; }
    public bool HasAce { get; private set; }

    public Hand()
    {
        Cards = new List<Card>();
        TotalValue = 0;
        HasAce = false;
    }

    public void AddCard(Card card)
    {
        Cards.Add(card);
        TotalValue += card.Value;

        if (card.Rank == "Ace")
        {
            HasAce = true;
        }

        if (TotalValue > 21 && HasAce)
        {
            TotalValue -= 10;
            HasAce = false;
        }
    }

    public bool IsBust()
    {
        return TotalValue > 21;
    }

    public bool IsBlackjack()
    {
        return TotalValue == 21 && Cards.Count == 2;
    }
}

