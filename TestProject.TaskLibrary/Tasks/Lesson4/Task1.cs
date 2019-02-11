using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson4
{
    public class Task1 : IRunnable
    {

        public static void CubeArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (array[i] * array[i] * array[i]);
            }
        }

        public static void OuputArray(int[] array)
        {
            for (int k = 0; k < array.Length; k++)
            {
                Console.WriteLine(array[k]);
            }
        }
        

        public void Run()
        {
            int[] array = { 2, 3, 5 };

            CubeArray(array);
            OuputArray(array);


        }
    }
}
