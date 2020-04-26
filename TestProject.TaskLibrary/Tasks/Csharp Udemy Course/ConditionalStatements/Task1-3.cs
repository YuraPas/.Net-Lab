using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Csharp_Udemy_Course.ConditionalStatements
{
    class Task1_3 : IRunnable
    {
        public void Run()
        {
            // #1

            int firstNumber;
            int secondNumber;

            Console.Write("Input 1st number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input 2nd number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber == secondNumber)
                Console.WriteLine($"{firstNumber} and {secondNumber} are equal.\n");
            else
                Console.WriteLine($"{secondNumber} and {secondNumber} are not equal.\n");


            // #2


            int userInput;
            int reminder;

            Console.Write("Input an integer : ");
            userInput = Convert.ToInt32(Console.ReadLine());

            reminder = userInput % 2;

            if (reminder == 0)
                Console.WriteLine($"{0} is an even integer.\n", userInput);
            else
                Console.WriteLine($"{0} is an odd integer.\n", userInput);



            // #3

            int checkNumber;

            Console.Write("Input an integer : ");
            checkNumber = Convert.ToInt32(Console.ReadLine());
            if (checkNumber >= 0)
                Console.WriteLine($"{checkNumber} is a positive number.\n");
            else
                Console.WriteLine($"{checkNumber} is a negative number. \n");

        }
    }
}
