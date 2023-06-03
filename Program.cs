// See https://aka.ms/new-console-template for more information
using BlackJack;

Deck deck = new();
deck.PrintDeck();
deck.ShuffleDeck();
deck.PrintDeck();
Player dealer = new("Dealer");
Player player = new("Player");
dealer.DrawCard(deck);
player.DrawCard(deck);
player.DrawCard(deck);
dealer.PrintHand();
player.PrintHand();