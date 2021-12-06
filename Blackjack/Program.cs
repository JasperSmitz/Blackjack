using System;
using System.Collections.Generic;
using System.Text;


namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerAmount;
            int playerStartingHand;
            Table table = new Table();

            Table.GenerateCards();
            Table.Shuffle();

            Console.WriteLine("How many players?");
            playerAmount = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < playerAmount; i++)
            {
                Table.AddPlayer();
            }

            Console.WriteLine("How many cards for each player?");
            playerStartingHand = Int32.Parse(Console.ReadLine());

            foreach (Player player in Table.players)
            {
                for (int i = 0; i < playerStartingHand; i++)
                {
                    player.Hit();
                }
            }

            foreach (Player p in Table.players)
            {
                Console.WriteLine(p.name);
                Player.ShowHand(p);
            }
        }
    }
}
