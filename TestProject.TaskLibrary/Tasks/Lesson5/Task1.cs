using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;
using TestProject.TaskLibrary.Tasks.Lesson5.Shared;

namespace TestProject.TaskLibrary.Tasks.Lesson5
{
    public class Task1 : IRunnable
    {
        public List<Person> peopleList;

        public List<Person> Initialize()
        {
            peopleList = new List<Person>()
            {
                new Person { Name = "Yuriy", Age = 14, PhoneNumbers = new List<string> { "0991790705", "0123231231"  } },
                new Person { Name = "Andrey", Age = 74, PhoneNumbers = new List<string> { "0324790705", "012332231231"  } },
                new Person { Name = "Sean", Age = 15, PhoneNumbers = new List<string> { "09917920705", "012323231231"  } }
            };
            return peopleList;
        }

        private static void Output(IEnumerable<Person> peopleList)
        {
            foreach (var person in peopleList)
            {
                Console.WriteLine($"Name: {person.Name}  Age: {person.Age}");
            }
        }
            

        public void Run()
        {
            peopleList = Initialize();
            Output(peopleList);           
        }

    }
}
