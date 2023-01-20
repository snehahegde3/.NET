using System;

namespace Inheritance
{
    //Internally every Class we create inherits from the Object class
    internal class Program //: Object
    {
        //defines a class interms of another class 

        //code reuse: more efficient, less coding time

        /*      Base Class
                    |
                    V
              Derived Class
        */

        /* In this case, 
         *              Electrical Device
         *                      |
         *                      V
         *           -----------------------
         *           |                     |
         *           V                     V
         *         Radio                  T V
        */

        static void Main(string[] args)
        {
            Radio new_radio = new Radio(false, "Sony");
            // method from base class
            new_radio.SwitchOn();
            // method from child class
            new_radio.ListenRadio();

            TV new_TV = new TV(true, "Panasonic");
            new_TV.SwitchOff();
            new_TV.WatchTV();

            Dog dog = new Dog("Meek", 12);
            dog.Play();
            dog.Eat();
        }

        
    }
}
