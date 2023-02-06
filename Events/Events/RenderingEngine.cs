using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class RenderingEngine
    {
        public RenderingEngine()
        {
            //subscribe to OnGameStart event 
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += StopGame;
        }
        private void StartGame()
        {
            Console.WriteLine("Rendering Engine started");
            Console.WriteLine("Drawing Visuals... ");
        }

        private void StopGame() { 
            Console.WriteLine("Rendering Engine stopped."); 
        }
    }
}
