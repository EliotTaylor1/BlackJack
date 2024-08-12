public class Dealer : Player
{
    public void PlayTurn(Deck deck)
    {
        while (Hand.TotalValue < 17)
        {
            DrawCard(deck);
        }
    }
}
