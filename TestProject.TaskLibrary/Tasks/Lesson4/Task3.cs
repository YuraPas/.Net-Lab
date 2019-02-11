using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson4
{
    public class Task3 : IRunnable
    {
        /// <summary>
        /// Method that check if given array is symmetrical
        /// </summary>
        /// <param name="array"></param>
        /// <returns>bool </returns>
        public static bool IsSymmetrical(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                //We are checking if symmetrical elements regarding center are equal
                //while iterating variable i
                if (arr[i] != arr[(arr.Length - 1) - i])
                    return false;
            }

            return true;
        }

        public void Run()
        {
            int[] firstTestArray = { 1, 2, 2, 1 };
            int[] secondTestArray = { 2, 5, 8, 5, 2 };
            int[] thirdTestArray = { 2, 4, 1, 9, 2 };


            Console.WriteLine($"First array is symetrical : {IsSymmetrical(firstTestArray)}");       //True
            Console.WriteLine($"Second array is symetrical : {IsSymmetrical(secondTestArray)}");     //True
            Console.WriteLine($"Third array is symetrical : {IsSymmetrical(thirdTestArray)}");       //False


        }
    }
}
