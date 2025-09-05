using InterviewProgrammingQuestions;
using InterviewProgrammingQuestions.Questions.Async;

Console.WriteLine("Choose a question to run:");
Console.WriteLine("1. Async Question1");
var choice = Console.ReadLine();

IQuestion question = choice switch
{
    "1" => new LongProcessAsync(),
    _ => null
};

question?.Run();