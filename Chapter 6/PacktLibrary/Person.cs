using System;
using System.Collections.Generic;
using static System.Console;
namespace Packt.Shared
{
    public class Person
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();
        // methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        public static Person Procreate(Person Father,Person Mother)
        {
            var baby = new Person{
                Name = $"Baby of {Father} and {Mother}"
            };
            Father.Children.Add(baby);
            Mother.Children.Add(baby);

            return baby;
        }

        public Person ProcreateWith(Person Parent){
            return Procreate(this,Parent);
        }

        public static Person operator *(Person Father,Person Mother){
            return Procreate(Father,Mother);
        }
    }
}