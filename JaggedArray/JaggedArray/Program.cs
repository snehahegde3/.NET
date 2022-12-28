using System;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //jagged array
            //each row can have variable number of elements
            int[][] jaggedArray = new int[4][];

            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5, 6, 7, 8 };
            jaggedArray[2] = new int[] { 9, 10, 11, 12, 13, 14 };
            jaggedArray[3] = new int[] { 15 };

            for(int i=0;i<jaggedArray.Length;i++)
            {
                for(int j = 0; j < jaggedArray[i].Length;j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
            }

            FamilyIntroduction();
            Console.ReadKey();


        }

        public static void FamilyIntroduction()
        {
            string[] family = new string[] { "a", "b" };
            string[] familyToo = new string[] { "c", "d" };
            string[][] friend = new string[][]
            {
                new string[] {"Sne", "Slok", "Dodot"},
                new string[] { "e", "f" },
                family, 
                familyToo

            };
            for(int i = 0; i < friend.Length; i++)
            {
                for(int j = 0; j < friend[i].Length; j++)
                {
                    Console.Write(friend[i][j] + " ");
                }
            }


        }
    }
}
