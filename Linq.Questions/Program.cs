// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

// Write logic to print numbers upto 10 without using loop and inbuilt func
Func(0);
void Func(int initialValue) //0
{
    if (initialValue == 10)
    {
        return;
    }
    Console.WriteLine(initialValue);
    Func(initialValue + 1);
}


var mixedList = new ArrayList();
mixedList.Add(0);
mixedList.Add("One");
mixedList.Add("Two");
mixedList.Add(3);
mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

IList<Student> studentList = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
};

var studentsInAscOrder = studentList.OrderBy(s =>  s.StudentName).Select(s=> new { s.StudentName,s.Age });

var stringResult = mixedList.OfType<int>();

var intResult = from s in mixedList.OfType<int>()
                select s;

var stud
    = from s in mixedList.OfType<Student>()
                select s;

foreach (var s in studentsInAscOrder)
    Console.WriteLine(s.Age);


Console.WriteLine("Split");

foreach (var item in intResult)
{
    Console.WriteLine(item);

}

foreach (var s in stud)
{
    Console.WriteLine(s.StudentName);

}

var test = new Test();
// test.Value = 10; // Error since this must be assigned while creating object.
test.Value2 = 20;

var test2 = new Test() { 
    Value=10
};

class Student
{
    public int StudentID { get; set; }
    public string? StudentName { get; set; }
    public int Age { get; set; }
}

// Diff between init and set
public class Test
{
    public int Value { get; init; }
    public int Value2 { get; set; }
}

