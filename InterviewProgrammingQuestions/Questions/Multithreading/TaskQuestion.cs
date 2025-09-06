using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgrammingQuestions.Questions.Multithreading
{
    internal class TaskQuestion :  IQuestionTaskAsync
    {
        public async Task Run() {
            Task task1 = new Task(() =>
            {
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine($"Task 1: {i}");
                    Task.Delay(1000).Wait();
                }
            });

            Task task2 = Task.Run(() =>
            {
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine($"Task 2: {i}");
                    Task.Delay(1000).Wait();
                }
            });

            Console.WriteLine("Before running tasks");
            task1.Start();

            await Task.WhenAll(task1, task2);
            Console.WriteLine("Both tasks completed");
        }
        
    }
}
