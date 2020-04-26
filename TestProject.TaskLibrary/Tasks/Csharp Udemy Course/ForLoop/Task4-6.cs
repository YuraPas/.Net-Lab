using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Csharp_Udemy_Course.ForLoop
{
    class Task4_6 : IRunnable
    {
        public void Run()
        {
            // #4

            int i, limit, sum = 0;
            double average;

            Console.Write("Input the 10 numbers : \n");
            for (i = 1; i <= 10; i++)
            {
                Console.Write($"Number-{i} :");
                limit = Convert.ToInt32(Console.ReadLine());
                sum += limit;
            }
            average = sum / 10.0;
            Console.Write("The sum of 10 no is : {0}\nThe Average is : {1}\n", sum, average);

            // #5 

            int iter, termNumber;

            Console.Write("Input number of terms : ");
            termNumber = Convert.ToInt32(Console.ReadLine());
            for (iter = 1; iter <= termNumber; iter++)
            {
                Console.Write("Number is : {0} and cube of the {1} is :{2} \n", iter, iter, (iter * iter * iter ));
            }

            // #6
            int userInput;
            userInput = Convert.ToInt32(Console.ReadLine());

            for (int k = 1;k <= 10; k++)
            {
                Console.Write($"{userInput} X {k} = {userInput * k} \n");
            }
        }
    }
    
}
