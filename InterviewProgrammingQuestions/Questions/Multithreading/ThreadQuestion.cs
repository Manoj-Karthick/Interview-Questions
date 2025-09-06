using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgrammingQuestions.Questions.Multithreading
{
    internal class ThreadQuestion : IQuestionVoidAsync
    {
        public void Run()
        {
            Thread thread = new Thread(PrintNumbers); // create a new thread
            thread.Start(); // start the thread

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Main: {i}");
                Thread.Sleep(500);
            }

            thread.Join(); // wait for the thread to complete
        }

        static void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"PrintNumbers: {i}");
                Thread.Sleep(500); // simulate work
            }
        }
    }
}
