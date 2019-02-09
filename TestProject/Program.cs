using System;
using System.Threading.Tasks;
using TestProject.Common.Core.Interfaces;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of .NetLab Tasks
            var tasks = new IRunnable[]
            {

                //Testing Lesson3
                /*
                new TaskLibrary.Tasks.Lesson3.Task1(),
                new TaskLibrary.Tasks.Lesson3.Task2(),
                new TaskLibrary.Tasks.Lesson3.Task3(),
                new TaskLibrary.Tasks.Lesson3.Task4()
                */
    
            };

            foreach (var task in tasks)
            {
                task.Run();
            }
            Console.ReadLine();
        }
    }
}
