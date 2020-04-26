using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Csharp_Udemy_Course.Arrays
{
    class Task5 : IRunnable
    {
        public void Run()
        {


            int[] array = new int[100];
            int[] copy = new int[100];
            int numbStored;
            int i, j;

            numbStored = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Input {numbStored} elements in the array :\n");
            for (i = 0; i < numbStored; i++)
            {
                Console.Write("element - {0} : ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (i = 0; i < numbStored; i++)
            {
                copy[i] = array[i];

            }

            for (i = 0; i < numbStored; i++)
            {
                for(j = 0; j < numbStored; j++)
                {
                    if (array[i] == copy[j])
                        Console.WriteLine($"Match is found - {array[i]}");
                        
                }
            }
            

        }
    }
}
