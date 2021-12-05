using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck playingDeck = new Deck();
            Player player = new Player();
            Dealer dealer = new Dealer();
            Deck.CreateDeck();
            Console.WriteLine("Created deck:");
            foreach (Card card in Deck.deck)
            {
                int value = card.Value();
                Console.WriteLine(card.Name() + " | Value = " + value.ToString());
            }
            Console.WriteLine();
            Deck.ShuffleDeck();
            Console.WriteLine("Shuffled deck:");
            foreach (Card card in Deck.deck)
            {
                int value = card.Value();
                Console.WriteLine(card.Name() + " | Value = " + value.ToString());
            }
            Console.WriteLine("");
            Console.WriteLine();
            Dealer.DealCardToPlayer();
            Dealer.DealCardToPlayer();
            Dealer.DealCardToPlayer();
            Dealer.DealCardToPlayer();
            Dealer.DealCardToPlayer();
            Console.WriteLine("Player hand:");
            foreach (Card card in Player.hand)
            {
                int value = card.Value();
                Console.WriteLine(card.Name() + " | Value = " + value.ToString());
            }
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine("Leftover deck:");
            foreach (Card card in Deck.deck)
            {
                int value = card.Value();
                Console.WriteLine(card.Name() + " | Value = " + value.ToString());
            }
        }
    }
}
