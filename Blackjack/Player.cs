using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class Player
    {
        public static List<Card> hand = new List<Card>();
        public int startingHand = 2;

        public Player()
        {
            hand = new List<Card>();
        }

        public static void Hit()
        {
            Dealer.DealCardToPlayer();
        }
    }
}
