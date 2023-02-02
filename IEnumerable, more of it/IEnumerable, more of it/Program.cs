namespace IEnumerable__more_of_it
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this is a generic IEnumerable variable taking any collection of type int 

            Console.WriteLine("Returning a IEnumerable");
            IEnumerable<int> unknownCollection;
            unknownCollection = GetCollection(1); 

            if(unknownCollection is Queue<int>)
            {
                Console.WriteLine("Queue");
            }
            else if(unknownCollection is List<int>)
            {
                Console.WriteLine("List");
            }
            // foreach on what we get back from GetCollection() 
            foreach(int i in unknownCollection)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\nSending an IEnumerable as an argument");
            List<int> numList = new List<int>() { 16, 17, 18, 19, 20 };
            CollectionSum(numList);

        }

        static IEnumerable<int> GetCollection(int option)
        {

            //this function promises to return an IEnumerable

            List<int> numberList = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> numbersQueue = new Queue<int>();
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            if(option == 1)
            {
                return numberList;
            }
            else if (option == 2)
            {
                return numbersQueue;
            }
            else
            {
                return new int[] { 11, 12, 13, 14, 15 };
            }

        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            // function takes in a generic IEnumerable as an argument 

            // any IEnumerable collection can be sent

            // i.e any collection that implements the IEnumerable interface can be sent
            int sum = 0;
             
            foreach(int i in anyCollection)
            {
                sum += i;
            }

            Console.WriteLine($"{sum} from {anyCollection.GetType()}");
        }
    }
}