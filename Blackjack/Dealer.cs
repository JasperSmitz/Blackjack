using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class Dealer
    {
        public List<Card> dealerHand = new List<Card>();
        public Deck playingDeck = new Deck();

        public Dealer()
        {
            dealerHand = new List<Card>();
            playingDeck = new Deck();
        }

        // Deze method dealt een kaart aan de speler door de eerste kaart uit het deck te kopieren
        // naar de hand list, en vervolgens de eerste kaart uit het originele deck te verwijderen
        public static void DealCardToPlayer()
        {
            Player.hand.Add(Deck.deck[0]);
            Deck.deck.Remove(Deck.deck[0]);
        }
    }
}
