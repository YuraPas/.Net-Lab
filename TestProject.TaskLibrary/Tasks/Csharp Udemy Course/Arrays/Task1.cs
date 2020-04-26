using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Csharp_Udemy_Course.Arrays
{
    class Task1 : IRunnable
    {
        public void Run()
        {

            int[] arr = new int[10];
            int i;
            Console.Write("\n\nRead and Print elements of an array:\n");
            Console.Write("-----------------------------------------\n");

            Console.Write("Input 10 elements in the array :\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.Write("\n");


        }
    }
}
