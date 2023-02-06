using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class AudioSystem
    {
        public AudioSystem()
        {
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += StopGame;
        }
        private void StartGame()
        {
            Console.WriteLine("Audio System started");
            Console.WriteLine("Drawing Visuals... ");
        }

        private void StopGame()
        {
            Console.WriteLine("Audio System stopped.");
        }
    }
}
