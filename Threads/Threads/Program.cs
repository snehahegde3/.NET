
namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Threads");
            //Thread.Sleep(10000);
            //new Thread(() =>
            //{
            //    Thread.Sleep(10000);
            //    Console.WriteLine("Thread 1");
            //}).Start();
            //new Thread(() =>
            //{
            //    Thread.Sleep(11000);
            //    Console.WriteLine("Thread 2");
            //}).Start();
            //new Thread(() =>
            //{
            //    Thread.Sleep(12000);
            //    Console.WriteLine("Thread 3");
            //}).Start();
            

            var taskCompletionSource = new TaskCompletionSource<bool>();
            //this tells is the task assigned to it worked out or didnt 

            var thread = new Thread(() =>
            {
                Console.WriteLine("In process");
                Thread.Sleep(3000);
                taskCompletionSource.TrySetResult(true);
            })
            { IsBackground= true };
            // to set background true 

            thread.Start();
            var test = taskCompletionSource.Task.Result;

            Console.WriteLine($"Thread number: {thread.ManagedThreadId}");
            Console.WriteLine($"{taskCompletionSource.Task.Result}");
            //true if worked false if not 

            // Thread.Abort() is used to stop a thread but not safe to use

            //Enumerable.Range(0, 1000).ToList().ForEach(x =>
            //{
                
            //    new Thread(() =>
            //    {
            //        Console.WriteLine($"Thread number {Thread.CurrentThread.ManagedThreadId} started ");
            //        Thread.Sleep(100);

            //        Console.WriteLine($"Thread number {Thread.CurrentThread.ManagedThreadId} ended ");
            //    }).Start();
            //});

            //Thread pool only creates some amount of threads instead of 1000 threads like the above code 
            //Puts it into a queue and reuses it when free
            // although, the memory stored in these might not be cleared when reusing 
            // the threads in the threadpool have isBackgroundThread = true
            Enumerable.Range(0, 1000).ToList().ForEach(x =>
            {

                ThreadPool.QueueUserWorkItem((o) =>
                {
                    Console.WriteLine($"Thread number {Thread.CurrentThread.ManagedThreadId} started ");
                    Thread.Sleep(100);

                    Console.WriteLine($"Thread number {Thread.CurrentThread.ManagedThreadId} ended ");
                });
            });

            Console.ReadKey();

        }
    }
}