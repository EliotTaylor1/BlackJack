using System;

public class BlackjackGame
{
    private Deck deck;
    private Player player;
    private Dealer dealer;

    public BlackjackGame()
    {
        deck = new Deck();
        player = new Player();
        dealer = new Dealer();
    }

    public void StartGame()
    {
        Console.WriteLine("Welcome to Blackjack!\n");

        // Initial deal
        player.DrawCard(deck);
        dealer.DrawCard(deck);
        player.DrawCard(deck);
        dealer.DrawCard(deck);

        // Show hands
        ShowHands(showDealerHand: false);

        // Player's turn
        while (!player.Hand.IsBust())
        {
            Console.WriteLine("Hit or Stand? (H/S): ");
            string choice = Console.ReadLine().ToUpper();

            if (choice == "H")
            {
                player.DrawCard(deck);
                ShowHands(showDealerHand: false);
            }
            else if (choice == "S")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, please enter H or S.");
            }
        }

        // Dealer's turn
        if (!player.Hand.IsBust())
        {
            dealer.PlayTurn(deck);
        }

        // Show final hands and determine winner
        ShowHands(showDealerHand: true);
        DetermineWinner();
    }

    private void ShowHands(bool showDealerHand)
    {
        Console.WriteLine("\nPlayer's Hand:");
        foreach (var card in player.Hand.Cards)
        {
            Console.WriteLine(card);
        }
        Console.WriteLine($"Total: {player.Hand.TotalValue}\n");

        Console.WriteLine("Dealer's Hand:");
        if (showDealerHand)
        {
            foreach (var card in dealer.Hand.Cards)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine($"Total: {dealer.Hand.TotalValue}\n");
        }
        else
        {
            Console.WriteLine(dealer.Hand.Cards[0]);
            Console.WriteLine("Hidden card");
        }
    }

    private void DetermineWinner()
    {
        if (player.Hand.IsBust())
        {
            Console.WriteLine("Player busts! Dealer wins.");
        }
        else if (dealer.Hand.IsBust())
        {
            Console.WriteLine("Dealer busts! Player wins.");
        }
        else if (player.Hand.TotalValue > dealer.Hand.TotalValue)
        {
            Console.WriteLine("Player wins!");
        }
        else if (player.Hand.TotalValue < dealer.Hand.TotalValue)
        {
            Console.WriteLine("Dealer wins!");
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }
    }
}
