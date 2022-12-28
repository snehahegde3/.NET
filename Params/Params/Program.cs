using System;

namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //overloads on hovering over a function gives the number of implementations it has
            Console.WriteLine();
            ParamsMethod("hey there", "youuu", "oh okeee");
            Console.WriteLine();
            int[] arr = new int[] { 1, 3, 4 };
            ParamsStuff(1, 3, 5, '%', "okkkee0", arr);
            Console.WriteLine();
            int[] res = new int[2];
            res = MinMax(1, 6, 4, -6, 7, 3, 56, 3, 6, 2, 6, 8, 0, -6, -6, -7, -8, -13, 6, 56, 76, 34, 65, 36, 76);
            Console.WriteLine($"min: {res[0]}, max: {res[1]}");
        }

        public static void ParamsMethod(params string[] sentence)
        {
            //a params should be the last parameter in a list of parameters
            for(int i=0;i< sentence.Length;i++)
            {
                Console.Write(sentence[i]+ " ");
            }
        }

        public static void ParamsStuff(params object[] stuff)
        {
            //object can be an array of any kind of objects
            //every data type has a defenition of ToString hence that can be used 
            //without actually calling it i.e. implicitly called 
            foreach (var obj in stuff)
            {
                Console.Write(obj + " ");
            }
        }

        public static int[] MinMax(params int[] numbers)
        {
            int[] minmax = new int[] { int.MaxValue, int.MinValue };
            foreach(int i in numbers)
            {
                if (i < minmax[0])
                {
                    minmax[0] = i;
                }
                if(i > minmax[1])
                {
                    minmax[1] = i;
                }
            }
            return minmax;
        }
    }
}
