using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2
{
    public class Task1 : IRunnable
    {
        public struct Person
        {
            public string Name;
            public string Surname;
            private int age;

            public Person(string name, string surname, int age)
            {
                Name = name;
                Surname = surname;
                this.age = age;
            }


            /// <summary>
            /// Method for Person structures that will define whether instance is older or younger that n 
            /// </summary>
            /// <param name="n"></param>
            /// <returns></returns>
            public string Compare(int n)
            {
                if (n > 0)
                {
                    if (n > this.age)
                    {
                        return ($"{this.Name} {this.Surname} is younger that {n}");
                    }
                    else
                    {
                        return ($"{this.Name} {this.Surname} is older or equal to {n}");
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public void Run()
        {
            Person pedestrian = new Person("Andrey", "Wass", 32);
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pedestrian.Compare(userInput));
        }
    }
}
