using System;
using System.Collections.Generic;

namespace Queues_BarnettLandon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates Game object containing 49 players with a max of 50
            Game myGame = new Game(50, 49);

            //Creates a new Que
            Queue<Player> waitingToJoinQ = new Queue<Player>();

            //Creates 4 unique players 
            Player p1 = new Player(100, "DarkPhantom8652");
            Player p2 = new Player(100, "Snaftt");
            Player p3 = new Player(100, "SulfurHex");
            Player p4 = new Player(100, "Zed_numbers");

            //Players try to join the game
            p1.JoinGame(myGame, waitingToJoinQ);
            p2.JoinGame(myGame, waitingToJoinQ);
            p3.JoinGame(myGame, waitingToJoinQ);
            p4.JoinGame(myGame, waitingToJoinQ);

            //prints statement then all the players in the que
            Console.WriteLine("Players in the Q:");
            foreach (Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }

            //removes player from the game then calls CheckQueue method
            myGame.KickPlayer();
            myGame.CheckQueue(waitingToJoinQ);

            //prints players now in que
            Console.WriteLine("\nPlayers in the Q:");
            foreach (Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }
        }
    }
}
