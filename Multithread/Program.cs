using System;
using System.Threading.Tasks;

//class Program
//{
//    static void PrintNumbers()
//    {
//        for (int i = 1; i <= 5; i++)
//        {
//            Console.WriteLine($"PrintNumbers: {i}");
//            Thread.Sleep(500); // simulate work
//        }
//    }

//    static void Main()
//    {
//        Thread thread = new Thread(PrintNumbers); // create a new thread
//        thread.Start(); // start the thread

//        for (int i = 1; i <= 5; i++)
//        {
//            Console.WriteLine($"Main: {i}");
//            Thread.Sleep(500);
//        }

//        thread.Join(); // wait for the thread to complete
//    }
//}

class Program
{
    static async Task Main()
    {
        Task task1 = new Task(() =>
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Task 1: {i}");
                Task.Delay(500).Wait();
            }
        });

        Task task2 = Task.Run(() =>
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Task 2: {i}");
                Task.Delay(500).Wait();
            }
        });

        Console.WriteLine("Before running tasks");
        task1.Start();

        await Task.WhenAll(task1, task2);
        Console.WriteLine("Both tasks completed");
    }
}
