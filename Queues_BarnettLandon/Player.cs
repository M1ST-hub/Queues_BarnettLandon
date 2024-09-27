using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_BarnettLandon
{
    internal class Player
    {
        //Creates health and gamertag for player params
        public int Health { get; set; }

        public string GamerTag { get; }

        //Creates player constructor giving the params
        public Player(int healthParam, string nameParam)
        {
            Health = healthParam;
            GamerTag = nameParam;
        }

        //Creates join game method which checks if game has max players and if the player can fit they will be added
        public void JoinGame(Game game, Queue<Player> queue)
        {
            if(game.CurrentPlayers == game.MaxPlayers)
            {
                queue.Enqueue(this);
            }
            else
            {
                Console.WriteLine("Joining Game!");
                game.CurrentPlayers++;
            }
        }

        //override string to return players gamertag
        public override string ToString()
        {
            return GamerTag;
        }

    }
}
