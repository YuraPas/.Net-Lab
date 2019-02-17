using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;
using TestProject.TaskLibrary.Tasks.Lesson5.Shared;

namespace TestProject.TaskLibrary.Tasks.Lesson5
{
    public class Task2 : IRunnable
    {
        private List<Person> InitializeSeparateList()
        {
            List<Person> AnotherList = new List<Person>()
            {
                new Person { Name = "NYuriy", Age = 14, PhoneNumbers = new List<string> { "0991790705", "0123231231"  } },
                new Person { Name = "NN", Age = 24, PhoneNumbers = new List<string> { "0324790705", "012332231231"  } }
            };
            return AnotherList;
        }

        private static void OutputItems(IEnumerable<Person> peopleList)
        {
            foreach (var item in peopleList)
            {
                foreach (var phoneNumb in item.PhoneNumbers)
                {
                    Console.WriteLine(phoneNumb);

                }
            }
        }

        public void Run()
        {
            Task1 instance = new Task1();

            List<Person> AnotherList = InitializeSeparateList();
            List<Person> peopleList = instance.Initialize();

            peopleList.AddRange(AnotherList);
            OutputItems(peopleList);
        }
    
    }
}
