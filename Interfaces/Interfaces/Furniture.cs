using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Furniture
    {
        // C# is a single inheritance language. 
        // Classes cannot inherit from multiple parent classes 
        public string Color { get; set; }
        public string Material { get; set; }
        public Furniture() {
            Color = "White";
            Material = "Wood";
        }

        public Furniture(string color, string material)
        {
            this.Color = color;
            this.Material = material;
        }
    }
}
