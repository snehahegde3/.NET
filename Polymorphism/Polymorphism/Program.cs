using System.Numerics;
using System.Security.Cryptography;

namespace Polymorphism
{
    internal class Program
    {

        public static void HasA()
        {
            Console.WriteLine("Has A");
            var Cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", "M3")
            };

            foreach (var car in Cars)
            {
                car.Repair();
            }

            Car bmw1 = new BMW(240, "green", "M7");
            bmw1.ShowDetails();

            M3 m31 = new M3(250, "silver", "M31");
            m31.Repair();

            bmw1.SetCarIDInfo(1234, "sne");
            bmw1.GetCarIDInfo();

            Console.WriteLine();
        }

        public static void Abstractin()
        {

            Shape cube1 = new Cube(100);
            Shape sphere1 = new Sphere(10);
            Shape[] shapes = new Shape[] { cube1, sphere1 };

            //cube1.GetInfo();
            foreach(var i in shapes)
            {
                Console.WriteLine(i.Volume());

                // the as keyword 
                Cube iceCube = i as Cube; 
                // we'ere saying we want to have ot as a specific data type

                if(iceCube == null)
                {
                    Console.WriteLine("This shape is no cube");
                }

                if(i is Cube)
                {
                    Console.WriteLine("This is a cube");
                }
            }

            //storing a Cube in an object and casting it to Cube when assigning to another CUbe 
            object cube2 = new Cube(8);
            Cube cube3 = (Cube)cube2;

            Console.WriteLine($"{cube3.Name}, {cube3.Volume()}");


        }

        static void Main(string[] args)
        {
            HasA();
            Abstractin();

        }

    }
}