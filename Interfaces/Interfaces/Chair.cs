using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Chair: Furniture, IDestroyable
    {
        public string DestructionSound { get; set; }
        public Chair(string color, string material) : base(color, material)
        {
           
            DestructionSound = "ChairDestructionSound.mp3";

        }

        public void Destroy()
        {
            Console.WriteLine($"The {Color} chair was destroyed\nPlaying destruction sound {DestructionSound}");
        }
    }
}
