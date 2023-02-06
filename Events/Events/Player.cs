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
        }
        public void StartGame()
        {
            Console.WriteLine($"Spawning player {Name}"); 

        }

        public void StopGame()
        {
            Console.WriteLine($"Removinf player {Name}");
        }
    }
}
