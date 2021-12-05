using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class Deck
    {
        public static List<Card> deck = new List<Card>();

        public Deck()
        {
            deck = new List<Card>();
        }

        // kaarten gemaakt en toegevoegd aan list met behulp van twee loops
        // buiten loop gaat door alle vier de suits en voor elke suit gaat het door alle mogelijke ranks
        public static void CreateDeck()
        {
            foreach (string i in Card.suits)
            {
                foreach (string j in Card.ranks)
                {
                    Card cardToAdd = new Card(i, j);
                    deck.Add(cardToAdd);
                }
            }
        }

        // shuffle op basis van Random. Dit is technisch gezien niet totaal random maar goed genoeg voor nu.
        // het plaatst willekeurige kaarten naar achter tot het door alle kaarten heen is.
        public static void ShuffleDeck()
        {
            int cardsToBeShuffled = deck.Count;
            Random rand = new Random();
            while (cardsToBeShuffled > 1)
            {
                int i = rand.Next(0, cardsToBeShuffled);
                cardsToBeShuffled--;
                Card value = deck[i];
                deck[i] = deck[cardsToBeShuffled];
                deck[cardsToBeShuffled] = value;
            }
        }
    }
}
