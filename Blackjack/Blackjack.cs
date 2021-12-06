using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class Blackjack
    {
        private Table table = new Table();

        public void StartGame()
        {
            // nog maken
        }

        // Deze method dealt een kaart aan de speler door de eerste kaart uit het deck te kopieren
        // naar de hand list, en vervolgens de eerste kaart uit het originele deck te verwijderen
        public static Card DealCardToPlayer()
        {
            Card cardToAdd = Table.cards[0];
            Table.cards.Remove(Table.cards[0]);
            return cardToAdd;
        }
    }
}
