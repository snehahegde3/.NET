using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Box
    {
        public int length;
        public int height; 
        public int width;
        public int volume;
        public Box() { }

        //a private method can only be called from inside the class itself
        //or all the classes that inherit from it 
        
        public void SetDimension(int length, int width, int height) {
            this.length = length;
            this.width = width;
            Height = height;
            
        }

        //property 
        public int Height
        {
            get { return this.height; }
            set
            { 
                if(value < 0){
                    this.height = -value;
                }
                else 
                    this.height = value;
            }
        }
        public int Width { get; set; }
        public int Length { get; set; }

        //same as 
        /*
         * public int Width{
         *     get{
         *         return width
         *     }
         *     set{
         *         width = value;
         *     }
         * }
         */

        public int Volume { get { return volume; } set { volume = height * length * width; } }

        public int[] GetDimensions()
        {
            int[] arr = { length, height, width };
            return arr;
        }

        public int GetVolume()
        {
            volume = length * width * height;
            return volume;
        }
            

        public void DisplayInfo() {
            Console.WriteLine($"The length is {length}, the height is {height}, width is {width}\nHence the volume is {GetVolume()}");
        }
    }
}
