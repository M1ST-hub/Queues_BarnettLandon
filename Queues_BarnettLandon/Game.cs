using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_BarnettLandon
{
    internal class Game
    {
        //Creates params for the game class to have a max players and current players
        public int MaxPlayers { get; }

        public int CurrentPlayers { get; set;  }

        //Creates Game constructor using the new params
        public Game(int maxP, int currentP) 
        { 
            MaxPlayers = maxP;
            CurrentPlayers = currentP;
        }

        //method to remove player when called
        public void KickPlayer()
        {
            CurrentPlayers--;
        }

        //method to check queue to determine firstly, there's room for more players then if there is players in que
        //if there are no players in que then that will be printed
        public void CheckQueue(Queue<Player> playerQueue)
        {
            if (CurrentPlayers < MaxPlayers)
            {
                if(playerQueue.Count > 0)
                {
                    playerQueue.Dequeue();
                    CurrentPlayers++;
                }
                else
                {
                    Console.WriteLine("No player in the queue!");
                }
            }
        }


    }
}
