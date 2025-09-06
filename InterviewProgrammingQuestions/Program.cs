using InterviewProgrammingQuestions;
using InterviewProgrammingQuestions.Questions.Async;
using InterviewProgrammingQuestions.Questions.Multithreading;

Console.WriteLine("Choose a question to run:");
Console.WriteLine("1. Long Process Async");
Console.WriteLine("2. Method Call Async");
Console.WriteLine("3. MultiThreading Task Question");
Console.WriteLine("4. MultiThreading Thread Question");
var choice = Console.ReadLine();

IQuestion question = choice switch
{
    "1" => new LongProcessAsync(),
    "2" => new MethodCallAsync(),
    _ => null
};

question?.Run();

IQuestionVoidAsync questionVoidAsync = choice switch
{
    "4" => new ThreadQuestion(),
    _ => null
};

questionVoidAsync?.Run();

IQuestionTaskAsync questionTaskAsync = choice switch
{
    "3" => new TaskQuestion(),
    _ => null
};

if (questionTaskAsync!=null)
{
    await questionTaskAsync?.Run();
}

Console.ReadKey();
