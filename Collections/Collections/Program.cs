using System;
using System.Collections;
using System.Collections.Generic;
namespace Collections
{
    internal class Program
    {
        //each collection is a class
        static void Main(string[] args)
        {
            ArrayLists();
            Console.ReadKey();
        }

        public static void ArraylistDisplay(ArrayList arrlist)
        {
            foreach(var i in arrlist)
            {
                if(i is System.Int32[])
                {
                    //the object is of the type System.Int32[]

                    //convert it into an enumerable to use foreach
                    IEnumerable arr = i as IEnumerable;
                    foreach(int j in arr)
                    {
                        Console.Write(j+ " ");
                    }
                }
                else if(i is System.String[]){
                    IEnumerable str = i as IEnumerable;
                    foreach(string j in str)
                    {
                        Console.Write(j+ " ");
                    }
                }
                else {
                    Console.Write(i + " ");
                }
                
            }
            Console.WriteLine();
        }
        public static void ArrayLists()
        {
            //Non-Generic
            ArrayList arrayList1 = new ArrayList();
            ArrayList arrayList2 = new ArrayList();
            arrayList1.Add(1);
            arrayList1.Add(10);
            arrayList1.Add(10);
            arrayList1.Add(65.6);
            arrayList1.Add("Hello");
            int[] arr = new int[] { 1, 2, 4 };
            string[] strArr = new string[] { "sne", "hegde" };
            arrayList1.Add(arr);
            arrayList1.Add(strArr);
            ArraylistDisplay(arrayList1);
            arrayList2 = arrayList1;


            //removes the first 10 from the arraylist
            arrayList1.Remove(10);
            ArraylistDisplay(arrayList1);

            //removes the element at the specified index
            arrayList1.RemoveAt(0);
            ArraylistDisplay(arrayList1);

            
        }

        public static void Lists()
        {
            List<int> newList = new List<int> { 5, 10, 15, 20, 25, 30, 35, 40, 45 };
            for(int i=0;i<newList.Count;i++)
            {
                Console.Write(i+ " ");
            }
        }
    }
}
