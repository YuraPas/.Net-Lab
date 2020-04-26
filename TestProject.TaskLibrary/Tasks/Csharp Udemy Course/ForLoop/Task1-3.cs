using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Csharp_Udemy_Course.ForLoop
{
    class Task1_3 : IRunnable
    {
        public void Run()
        {

            // #1
            Console.WriteLine("The first 10 natural number are:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0} ", i);
            }

            // #2 

            int sum = 0;

            for (int j = 1; j <= 10; j++)
            {
                sum += j;
            }
            Console.Write($"\nThe Sum is : {sum}\n");

            // #3

            int iter, n, summ = 0;

            Console.Write("Input Value of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe first {0} natural number are :\n", n);
            for (iter = 1; iter <= n; iter++)
            {
                Console.Write($"{iter} ");
                summ += iter;
            }
            Console.Write("\nThe Sum of Natural Number upto {0} terms : {1} \n", n, summ);

        }
    }
}
