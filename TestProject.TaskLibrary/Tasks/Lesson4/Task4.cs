using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson4
{
    public class Task4 : IRunnable
    {
        private static int[] FormVector(int[,] array, int rows, int cols)
        {
            int[] result = new int[rows];
            int max = 0;


            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < cols; k++)
                {
                    if (array[i, k] > max)
                    {
                        max = array[i, k];
                    }
                }
                result[i] = max;
                max = 0;
            }

            return result;
        }

        private static void InitializeArray(int[,] array, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < cols; k++)
                {
                    Console.Write($"Enter arr[{i}][{k}]: ");
                    array[i, k] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        private static void OutputArray(int[] array, int rows)
        {
            for (int i = 0; i < rows; i++)
            {

                Console.WriteLine(array[i]);
            }
        }


        public void Run()
        {
            try
            {

                Console.Write("Input number of rows: ");
                int rows = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input number of columns: ");
                int cols = Convert.ToInt32(Console.ReadLine());

                if (rows < 1 || cols < 1)
                    throw new ArgumentException();


                int[,] array = new int[rows, cols];


                InitializeArray(array, rows, cols);

                int[] result = FormVector(array, rows, cols);

                OutputArray(result, rows);

            }

            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
