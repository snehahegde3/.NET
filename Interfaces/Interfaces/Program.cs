using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PreDefinedInterfaces();
            UserDefinedInterfaces();
            EnumeratorsAndEnumerables();
            
        }

        static public void PreDefinedInterfaces()
        {
            Console.WriteLine("Pre defined");

            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(10);

            Console.WriteLine(t2.Equals(t1));

            Console.WriteLine();
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

            Console.WriteLine();
        }

        static public void EnumeratorsAndEnumerables()
        {
            Console.WriteLine("IEnumerator");
            // IEnumerable <T> is used for generic collections
            // IEnumerable is used for non generic collections 

            DogShelter shelter = new DogShelter(); 

            foreach(Dog dogi in shelter)
            {
                // this alone gives an error that says 
                // foreach statement cannot operate on variables of type 'type1' because 'type2' does not contain a public definition for 'identifier'
                // so we need to use the IEnumerable interface on DogShelter

                if (!dogi.IsNaughtyDog)
                {
                    dogi.Givetreat(2);
                }
                else
                {
                    dogi.Givetreat(1);
                }
            }

            // when to use? 
            // when we have a massive database table 
            // you dont want to copy the enire thing into memory causing performance issues
            // when not recommended to use IEnumerable interface: 
            // when we need the results right away

        }
    }
}
