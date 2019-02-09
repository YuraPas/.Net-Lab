using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Csharp_Udemy_Course.Arrays
{
    class Task4 : IRunnable
    {
        public void Run()
        {

            int[] source = new int[100];
            int[] destination = new int[100];
            int i;
            int n;

            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                source[i] = Convert.ToInt32(Console.ReadLine());
            }
   
            for (i = 0; i < n; i++)
            {
                destination[i] = source[i];
            }
 
            Console.Write("\n\nThe elements copied into the second array are :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", destination[i]);
            }
            Console.Write("\n\n");


        }
    }
}
