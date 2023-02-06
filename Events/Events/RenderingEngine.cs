using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class RenderingEngine
    {
        public void StartGame()
        {
            Console.WriteLine("Rendering Engine started");
            Console.WriteLine("Drawing Visuals... ");
        }

        public void StopGame() { 
            Console.WriteLine("Rendering Engine stopped."); 
        }
    }
}
