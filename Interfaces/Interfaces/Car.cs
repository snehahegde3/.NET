using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Car: Vehicle, IDestroyable
    {
        // the destroy method needs to be included to be able to use the IDestroyable interface 

        //public string DestructionSound { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public void Destroy()
        //{
        //    throw new NotImplementedException();
        //}

        public string DestructionSound { get; set; }

        // When a car destroys, all the things around it destroy as well. 
        // So we create a new property to store the destroyable objects nearby 
        // list is of type IDestroyable which means it can store any object that implemnts the Interface 
        // we can only access the properties and methods in this interface 

        public List<IDestroyable> DestroyablesNearby;
        public Car(float speed, string color):base(speed, color) {
            DestructionSound = "CarExlosionSound.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }

        public void Destroy()
        {
            Console.WriteLine($"Playing destruction sound {DestructionSound}");
            Console.WriteLine("Theres a fire. Run ");

            // going through every destroyable object nearby and destoying it 
            foreach(IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }

    }
}
