<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Cube: Shape
    {
        public double Length { get; set; }

        public Cube(double length):base("Cube")
        {
            Length = length;
        }
        // now this MUST implement Volume() 
        public override double Volume()
        {
            //return Length * Length * Length;
            return Math.Pow(Length, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"\nThis is a {Name} with Length {Length}");
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Cube: Shape
    {
        public double Length { get; set; }

        public Cube(double length):base("Cube")
        {
            Length = length;
        }
        // now this MUST implement Volume() 
        public override double Volume()
        {
            //return Length * Length * Length;
            return Math.Pow(Length, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"\nThis is a {Name} with Length {Length}");
        }
    }
}
>>>>>>> 2170fdea099c42cf38602e30ca82b2f6e5228ac6
