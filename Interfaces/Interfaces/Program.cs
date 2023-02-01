using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PreDefinedInterfaces();
            UserDefinedInterfaces();
            
        }

        static public void PreDefinedInterfaces()
        {
            Console.WriteLine("Pre defined");
            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(10);
            Console.WriteLine(t2.Equals(t1));
        }

        static public void UserDefinedInterfaces()
        {
            Console.WriteLine("User defined");
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            Car damagedCar = new Car(80f, "Blue");

            //adding the two instantiations of the chair to the list of destroyables near the car 
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            damagedCar.Destroy();
        }
    }
}
