
namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Threads");
            Thread.Sleep(10000);
            new Thread(() =>
            {
                Thread.Sleep(10000);
                Console.WriteLine("Thread 1");
            }).Start();
            new Thread(() =>
            {
                Thread.Sleep(11000);
                Console.WriteLine("Thread 2");
            }).Start();
            new Thread(() =>
            {
                Thread.Sleep(12000);
                Console.WriteLine("Thread 3");
            }).Start();
            

            var taskCompletionSource = new TaskCompletionSource<int>();

        }
    }
}