using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;

namespace MyFirstCSharpApp.models
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Job { get; set; }

        public Person(string Name, int Age, string City)
        {
            this.Name = Name;
            this.Age = Age;
            this.City = City;
        }

    }
}
