using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson4
{
    public class Task2 : IRunnable
    {
        public static bool isPrime(int number)

        {
            if (number == 1) return false;
            if (number == 2) return true;

            var limit = Math.Ceiling(Math.Sqrt(number));

            for (int i = 2; i <= limit; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;

        }


        public static int Count(int [] array)
        {
            int count = 0;
            for (int k = 0; k < array.Length; k++)
            {
                if (isPrime(array[k]))
                {
                    count++;
                }
            }
            return count;
        }

        public void Run()
        {
            int[] PrimeArray = { 1, 2, 3, 4, 5, 6, 7, 13 };
            int count = Count(PrimeArray);

            Console.WriteLine(count);
        }
    }
}
