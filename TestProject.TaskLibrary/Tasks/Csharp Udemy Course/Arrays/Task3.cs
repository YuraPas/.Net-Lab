using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Csharp_Udemy_Course.Arrays
{
    class Task3 : IRunnable
    {
        public void Run()
        {
            int[] arr = new int[100];
            int i;
            int sum = 0;


            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);



        }
    }
}
