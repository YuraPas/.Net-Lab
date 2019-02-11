using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson4
{
    public class Task5 : IRunnable
    {
        private static int[] FormVector(int[][] array, int rows)
        {
            int[] result = new int[rows];
            int max = 0;


            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < array[i].Length; k++)
                {
                    if (array[i][k] > max)
                    {
                        max = array[i][k];
                    }
                }
                result[i] = max;
                max = 0;
            }

            return result;
        }

        private static void OutputArray(int[] array, int rows)
        {
            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine(array[i]);
            }
        }


        public void Run()
        {
            int rows = 4;

            int[][] array = new int[][]
                {
                    new int[] {3, 4, 1, 8},
                    new int[] {1, 4, 9, 11},
                    new int[] {76, 34, 21, 1},
                    new int[] {2, 1, 4, 5}
                };


            int[] result = FormVector(array, rows);

            OutputArray(result, rows);
        }
    }
}
