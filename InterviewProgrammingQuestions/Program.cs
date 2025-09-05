using InterviewProgrammingQuestions;
using InterviewProgrammingQuestions.Questions.Async;

Console.WriteLine("Choose a question to run:");
Console.WriteLine("1. Long Process Async");
Console.WriteLine("1. Method Call Async");
var choice = Console.ReadLine();

IQuestion question = choice switch
{
    "1" => new LongProcessAsync(),
    "2" => new MethodCallAsync(),
    _ => null
};

question?.Run();