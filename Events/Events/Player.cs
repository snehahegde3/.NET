using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Player
    {
        public string Name { get; set; }
        public Player(string Name)
        {
            this.Name = Name;
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += StopGame;
        }
        private void StartGame()
        {
            Console.WriteLine($"Spawning player {Name}"); 

        }

        private void StopGame()
        {
            Console.WriteLine($"Removinf player {Name}");
        }
    }
}
