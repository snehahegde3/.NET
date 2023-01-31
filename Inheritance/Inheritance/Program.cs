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

            Post newPost = new Post("Happy birthday", true, "sne");
            Console.WriteLine(newPost.ToString());

            ImagePost newImgPost = new ImagePost("Dotdot in all her glory", "dotie", "http://dotdot/images/kyooti.png", true);
            Console.WriteLine(newImgPost.ToString());

            VideoPost newVideoPost = new VideoPost("http://dotdot/videos", 10, "New dotdot video", true, "sne");
            Console.WriteLine(newVideoPost.ToString());
            newVideoPost.Play();
            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();
            newVideoPost.Stop();
        }

        
    }
}
