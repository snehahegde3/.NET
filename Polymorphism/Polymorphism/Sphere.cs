<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Sphere: Shape
    {
        public double Radius { get; set; }

        public Sphere(double radius):base("Sphere") {
            Radius = radius;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"{Name} with radius {Radius}");
        }
        public override double Volume()
        {
            return (4/3) * Math.PI * Math.Pow(Radius, 3);
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
    internal class Sphere
    {
    }
}
>>>>>>> 2170fdea099c42cf38602e30ca82b2f6e5228ac6
