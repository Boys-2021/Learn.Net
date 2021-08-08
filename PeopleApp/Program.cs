using System;
using static System.Console;
using Classes.shared;


namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person hi = new Person();
            hi.Name = "Adrian";
            hi.DateOfBirth = new DateTime(2000,10,5);

            WriteLine($"{hi.Name} is {hi.DateOfBirth:d/MM/yyyy}");
            hi = new Person
{
 Name = "Alice Jones",
 DateOfBirth = new DateTime(1998, 3, 7)
};

            WriteLine($"{hi.Name} is {hi.DateOfBirth:d/MM/yyyy}");

            hi.wonders = Wonders.Kotahena| Wonders.Dehiwala;

            WriteLine(hi.wonders);
        }
    }
}
