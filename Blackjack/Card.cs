using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class Card
    {
        public static string[] suits = { "Clubs", "Hearts", "Spades", "Diamonds" };
        public static string[] ranks = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

        public string suit;
        public string rank;

        // constructor neemt de suit en rank die in de Deck class worden gegenereerd
        public Card(string s, string r)
        {
            this.suit = s;
            this.rank = r;
        }

        // method om de naam van de kaart te genereren
        public string Name()
        {
            return rank + " of " + suit;
        }

        // basis values, ik hoop de mogelijkheid toe te voegen voor Ace om 1 of 11 te zijn
        // wanneer dit volgens blackjack regels hoort
        public int Value()
        {
            switch (rank)
            {
                case "Ace":
                    return 1;
                case "Two":
                    return 2;
                case "Three":
                    return 3;
                case "Four":
                    return 4;
                case "Five":
                    return 5;
                case "Six":
                    return 6;
                case "Seven":
                    return 7;
                case "Eight":
                    return 8;
                case "Nine":
                    return 9;
                case "Ten":
                case "Jack":
                case "Queen":
                case "King":
                    return 10;
                default:
                    return 0;
            }
        }
    }
}
