using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Csharp_Udemy_Course.Basic
{
    class Task1_4 : IRunnable
    {
        public void Run()
        {
            // #1
            Console.WriteLine("Hello");
            Console.WriteLine("Yuriy Paslavsky");
            // #2 
            Console.WriteLine(66 + 33);

            // #3 
            Console.WriteLine(20 / 4);

            // #4
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

        }
    }
}
