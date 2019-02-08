using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Csharp_Udemy_Course.DataTypes
{
    class Task1_2 : IRunnable
    {

        public void Run()
        {

            // #1
            char firstInputChar, secondInputChar, thirdInputChar;

            Console.Write("Input letter: ");
            firstInputChar = Convert.ToChar(Console.ReadLine());

            Console.Write("Input letter: ");
            secondInputChar = Convert.ToChar(Console.ReadLine());

            Console.Write("Input letter: ");
            thirdInputChar = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"{thirdInputChar} {secondInputChar} {firstInputChar}");


            // #2 
            Console.Write("Input a number: ");
            int printNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the desired width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            int height = width;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(printNumber);
                }

                Console.WriteLine();
                width--;
            }

        }
    }
}
