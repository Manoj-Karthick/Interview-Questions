﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgrammingQuestions.Questions.Async
{
    internal class LongProcessAsync : IQuestion
    {
        public void Run()
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            Task<int> result1 = LongProcess1();
            Task<int> result2 = LongProcess2();
            Console.WriteLine("After two long processes.");

            int val = await result1;
            DisplayResult(val);

            val = await result2;
            DisplayResult(val);

            Console.ReadKey();
        }

        static async Task<int> LongProcess1()
        {
            Console.WriteLine("LongProcess 1 Started");

            await Task.Delay(8000);

            Console.WriteLine("LongProcess 1 Completed");

            return 10;
        }

        static async Task<int> LongProcess2()
        {
            Console.WriteLine("LongProcess 2 Started");

            await Task.Delay(4000);

            Console.WriteLine("LongProcess 2 Completed");

            return 20;
        }

        static void DisplayResult(int val)
        {
            Console.WriteLine(val);
        }
    }


}
