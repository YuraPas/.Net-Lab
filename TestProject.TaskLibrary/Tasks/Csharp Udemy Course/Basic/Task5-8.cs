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
            int firstNumb;
            int secondNumb;
            int buffer;

            Console.Write("\nInput the First Number : ");
            firstNumb = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            secondNumb = int.Parse(Console.ReadLine());

            buffer = firstNumb;
            firstNumb = secondNumb;
            secondNumb = buffer;

            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + firstNumb);
            Console.Write("\nSecond Number : " + secondNumb);
            Console.Read();


            // #6
            int firstNumber;
            int secondNumber;
            int thirdNumber;

            Console.Write("Input the first number to multiply: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            thirdNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Output: {firstNumber} x {secondNumber} x {thirdNumber} = {firstNumber * secondNumber * thirdNumber}");


            // #7 

            Console.Write("Enter a number: ");
            int testFirstNumb = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int testSecondNumb = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", testFirstNumb, testSecondNumb, testFirstNumb + testSecondNumb);
            Console.WriteLine("{0} - {1} = {2}", testFirstNumb, testSecondNumb, testFirstNumb - testSecondNumb);
            Console.WriteLine("{0} x {1} = {2}", testFirstNumb, testSecondNumb, testFirstNumb * testSecondNumb);
            Console.WriteLine("{0} / {1} = {2}", testFirstNumb, testSecondNumb, testFirstNumb / testSecondNumb);
            Console.WriteLine("{0} mod {1} = {2}", testFirstNumb, testSecondNumb, testFirstNumb % testSecondNumb);

            // #8

            Console.WriteLine("Enter a number:");
            int input = Convert.ToInt32(Console.ReadLine());

            int result = input * 1;
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



        }
    }
}
