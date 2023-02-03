using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Audi: Car
    {
        public string Model { get; set; }
        private string Brand { get; set; }

        public Audi(int HP, string Color, string Model) : base(HP, Color)
        {
            this.Model = Model;
            Brand = "Audi";
        }

        public override void Repair()
        {
            Console.WriteLine($"audis {Model} is being repaired");
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"Audis {Model} with {HP} and color {Color}");
        }
    }
}
