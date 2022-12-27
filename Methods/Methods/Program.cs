using System;
using System.ComponentModel;
using System.Data.Common;

namespace Methods
{
    internal class Program
    {
        //the main method is the entry point for every c# application 
        //called by common language runtime (CLR) when the program is started

        //<Access Specifier> <Return Type> <Method Name> (Parameter List)
        //{
        //      Method Body 
        //}
        static void Main(string[] args)
        {
            
            bool flag = true;
            int intInputOne, intInputTwo, res;
            do
            {
                try
                {
                    
                    Console.WriteLine("Enter numbers: ");
                    string stringInputOne = Console.ReadLine();
                    string stringInputTwo = Console.ReadLine();
                    
                    intInputOne = int.Parse(stringInputOne);
                    intInputTwo = int.Parse(stringInputTwo);
                    res = Add(intInputOne, intInputTwo);

                    flag = false;
                    Console.WriteLine("Result: {0}", res);


                }
                catch (FormatException fex)
                {
                    Console.WriteLine(fex.Message + ". Please enter valid input next time. ");
                    
                }
                catch (OverflowException oex)
                {
                    Console.WriteLine(oex.Message + ". Please enter valid input next time. ");
                   
                }
                catch (ArgumentNullException anex)
                {
                    Console.WriteLine(anex.Message + ". Please enter valid input next time. ");
                    
                }
                finally
                {

                    Console.ReadKey();
                    Console.Clear();

                }
            } while (flag);

            Operators();
            Console.ReadKey();
            
            
        }

        //as main is static, even this should be static, otherwise, main cant call it
        //<Access Specifier> (static) <Return Type> <Method Name> (Parameter List)
        //{
        //      Method Body 
        //}
        //static as it is specific to that type 
        public static int Add(int num1, int num2)
        {
            int result = num1+ num2;
            return result;
        }

        public static void Operators()
        {
            int num = 1, num1 = 2;
            bool bul = true;
            string str = num.ToString() + bul.ToString();
            Console.WriteLine("{0} {1} {2}", -num, !bul, str);
            bool bul1 = num1 == num;
            Console.WriteLine(bul1);
            bool bul2 = bul && bul1;

        }
    }
}
