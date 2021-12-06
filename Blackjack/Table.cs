using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class Table
    {
        public static List<Player> players = new List<Player>();
        private Dealer dealer;
        public static List<Card> cards = new List<Card>();

        public Table()
        {
            players = new List<Player>();
            dealer = new Dealer("naam");
            cards = new List<Card>();
        }

        public static void AddPlayer()
        {
            string playerName;
            Console.WriteLine("Player name?");
            playerName = Console.ReadLine();
            players.Add(new Player(playerName));
        }
        // kaarten gemaakt en toegevoegd aan list met behulp van twee loops
        // buiten loop gaat door alle vier de suits en voor elke suit gaat het door alle mogelijke ranks
        public static void GenerateCards()
        {
            string[] suits = { "Clubs", "Hearts", "Spades", "Diamonds" };
            string[] ranks = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    Card cardToAdd = new Card(suit, rank);
                    cards.Add(cardToAdd);
                }
            }
        }

        // shuffle op basis van Random. Dit is technisch gezien niet totaal random maar goed genoeg voor nu.
        // het plaatst willekeurige kaarten naar achter tot het door alle kaarten heen is.
        public static void Shuffle()
        {
            int cardsToBeShuffled = cards.Count;
            Random rand = new Random();
            while (cardsToBeShuffled > 1)
            {
                int i = rand.Next(0, cardsToBeShuffled);
                cardsToBeShuffled--;
                Card value = cards[i];
                cards[i] = cards[cardsToBeShuffled];
                cards[cardsToBeShuffled] = value;
            }
        }

    }
}
