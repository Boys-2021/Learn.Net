using System;
using static System.Console;
using Classes.shared;
using Classes;

namespace PeopleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Trial Try = new Trial{Id = "hi"};
            Trial Tmy = new Trial{Id = "hello"};
            WriteLine(Try.Id + Tmy.Id);
        }

    }
}
