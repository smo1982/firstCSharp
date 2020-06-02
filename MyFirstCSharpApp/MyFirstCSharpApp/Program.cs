using Logic;
using MyFirstCSharpApp.models;
using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Runtime.CompilerServices;

namespace MyFirstCSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            //List<string> textFinish = new List<string>();
            string[] myFileContent = System.IO.File.ReadAllLines("C:\\Users\\DCV\\Downloads\\persons.txt");
            foreach(string a in myFileContent)
            {
                string[] textWord = a.Split(";");
                int age = 0;
                Int32.TryParse(textWord[1], out age);
                Person person = new Person(textWord[0], age, textWord[2]);
                if(person.Name == "Hans" || person.Name == "Helga")
                {
                    person.Job = "Coder";
                } else
                {
                    person.Job = "Officer";
                }
                people.Add(person);
            }
            string[] writeText = new string[people.Count];
            for(int i = 0; i < people.Count; i++ )
            {
                writeText[i] = people[i].Name + ";" + people[i].Age + ";" + people[i].City + ";" + people[i].Job;
            }


             System.IO.File.WriteAllLines("C:\\Users\\DCV\\Downloads\\persons1.txt", writeText);

            Console.ReadKey();
        }
    }
}
