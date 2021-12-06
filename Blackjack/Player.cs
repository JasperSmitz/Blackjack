using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class Player
    {
        public string name;
        protected List<Card> hand = new List<Card>();

        public Player(string _name)
        {
            this.name = _name;
            hand = new List<Card>();
        }

        public void Hit()
        {
            hand.Add(Blackjack.DealCardToPlayer());
        }

        // puur gemaakt om in de console aan te kunnen tonen dat er correct gedealt wordt
        public static void ShowHand(Player player)
        {
            foreach (Card card in player.hand)
            {
                Console.WriteLine(card.Name());
            }
        }
    }
}
