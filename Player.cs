public class Player
{
    public Hand Hand { get; private set; }

    public Player()
    {
        Hand = new Hand();
    }

    public void DrawCard(Deck deck)
    {
        Hand.AddCard(deck.DrawCard());
    }
}
