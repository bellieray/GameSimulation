using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class PlayerManager
    {
        public void RegisterPlayer(PlayerInfo player)
        {
            Console.WriteLine("Player is registered  : " + player.Username);
        }
        public void DeletePlayer(PlayerInfo player)
        {
            Console.WriteLine("Player is deleted : " + player.Username  );
        }
        public void UpdatePlayer(PlayerInfo player)
        {
            Console.WriteLine("Player is updated: " + player.Username);
        }
    }
}
