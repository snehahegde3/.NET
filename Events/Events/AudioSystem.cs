using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class AudioSystem
    {
        public void StartGame()
        {
            Console.WriteLine("Audio System started");
            Console.WriteLine("Drawing Visuals... ");
        }

        public void StopGame()
        {
            Console.WriteLine("Audio System stopped.");
        }
    }
}
