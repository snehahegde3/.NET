﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class BMW: Car
    {
        public string Model { get; set; }
        private string Brand { get; set; }

        public BMW(int HP, string Color, string Model):base(HP, Color)
        {
            this.Model = Model;
            Brand = "BMW";
        }
        

        // if you dont want a function to be overriden in the child class
        // the sealed keyword can be used 
        // it has to be used before the override keyword otherwise, it wont work 

        public sealed override void Repair()
        {
            Console.WriteLine($"BMWs {Model} is being repaired");
        }

        // the new keyowrd can be used to a function where we only will be able to use this particular method 
        // and not the base class method 
        // when we create a new object of this child class 
        public new void ShowDetails()
        {
            Console.WriteLine($"BMWs {Model} with {HP} and color {Color}");
        }

    }
}
