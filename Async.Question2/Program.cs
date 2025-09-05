Console.WriteLine("Main Started");
Method1();
Console.WriteLine("Main End");
Console.ReadLine();


static async void Method1()
{
    Console.WriteLine("Method1 Started");
    await Method2();
    Console.WriteLine("Method1 End");
}

static async Task Method2()
{
    Console.WriteLine("Method2 Started");
    await Task.Delay(1000);
    Console.WriteLine("Method2 End");
}