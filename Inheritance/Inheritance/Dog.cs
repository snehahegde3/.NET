using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Dog : Animal
    {
        public bool IsHappy { get; set; }
        public Dog(string name, int age):base(name, age)
        {
            IsHappy = true;
        }

        //this overrides the method from the parent class Animal
        public override void Eat()
        {
            //base is a reference to the base class 
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Wuuuf !");
        }

        public override void Play()
        {
            if(IsHappy)
            {
                base.Play();
            }
        }
    }
}
