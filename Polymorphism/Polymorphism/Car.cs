using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }
        public Car(int HP, string Color)
        {
            this.HP = HP;
            this.Color = Color;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"HP: {HP}, Color: {Color}");
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }
        

    }

}
