using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Csharp_Udemy_Course.Basic
{
    class Task5_8 : IRunnable
    {
        public void Run()
        {
            // #5
            int firstNumber, secondNumber,thirdNumber, result;

            Console.Write("Input the first number to multiply: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            thirdNumber = Convert.ToInt32(Console.ReadLine());

            result = firstNumber * secondNumber * thirdNumber;
            Console.WriteLine($"Output: {firstNumber} x {secondNumber} x {thirdNumber} = {result}");


            // #6 

            Console.Write("Enter a number: ");
            int testFirstNumb = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int testSecondNumb = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", testFirstNumb, testSecondNumb, testFirstNumb + testSecondNumb);
            Console.WriteLine("{0} - {1} = {2}", testFirstNumb, testSecondNumb, testFirstNumb - testSecondNumb);
            Console.WriteLine("{0} x {1} = {2}", testFirstNumb, testSecondNumb, testFirstNumb * testSecondNumb);
            Console.WriteLine("{0} / {1} = {2}", testFirstNumb, testSecondNumb, testFirstNumb / testSecondNumb);
            Console.WriteLine("{0} mod {1} = {2}", testFirstNumb, testSecondNumb, testFirstNumb % testSecondNumb);

            // #7 

            Console.WriteLine("Enter a number:");
            int input = Convert.ToInt32(Console.ReadLine());
            
            result = input * 1;
            Console.WriteLine("The table is : {0} x {1} = {2}", input, 1, result);
            result = input * 2;
            Console.WriteLine("/t: {0} x {1} = {2}", input, 2, result);
            result = input * 3;
            Console.WriteLine("/t: {0} x {1} = {2}", input, 3, result);
            result = input * 4;
            Console.WriteLine("/t: {0} x {1} = {2}", input, 4, result);
            result = input * 5;
            Console.WriteLine("/t: {0} x {1} = {2}", input, 5, result);
            result = input * 6;

            // #8


            char char1, char2, char3;

            Console.Write("Input letter: ");
            char1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Input letter: ");
            char2 = Convert.ToChar(Console.ReadLine());

            Console.Write("Input letter: ");
            char3 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"{char1} {char2} {char3}");

        }
    }
}
