using System;
using System.Collections.Generic;

namespace Classes.shared
{
    public class Person : System.Object
    {

        public string Name;
        public DateTime DateOfBirth;

        public Wonders wonders;

        public List<Person> Children = new List<Person>();
    }
}
