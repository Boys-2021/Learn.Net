using System;
using static System.Console;
using Classes.shared;
using Classes;
using PeopleApp.Classes;

namespace PeopleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Pokemon pikachu = new Pokemon{Name = "Pikachu",Color = "Yellow"};
            var (name,color) = pikachu;
            WriteLine(format:"{0} is {1} color",arg0:name,arg1:color);
        }

    }
}
