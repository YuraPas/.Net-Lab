using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Csharp_Udemy_Course.DataTypes
{
    class Task3_4 : IRunnable
    {
        public void Run()
        {
            // #3

            string username;
            string password;
            bool success = false;
            int attempts = 0;

            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();
                if (username == "admin" && password == "pass")
                {
                    success = true;
                    Console.Write("\nPassword entered successfull!\n\n");
                }
                else
                {
                    attempts++;
                    if (attempts > 3)
                    {
                        Console.WriteLine("Login attemp more than three times. Try later!");
                        break;
                    }
                }
            }
            while ((username != "admin" || password != "pass") && (!success));



            // #4

            int firstInput, secondInput;
            char operationChar;

            Console.Write("Input first number: ");
            firstInput = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input operation: ");
            operationChar = Convert.ToChar(Console.ReadLine());

            Console.Write("Input second number: ");
            secondInput = Convert.ToInt32(Console.ReadLine());

            if (operationChar == '+')
                Console.WriteLine("{0} + {1} = {2}", firstInput, secondInput, firstInput + secondInput);
            else if (operationChar == '-')
                Console.WriteLine("{0} - {1} = {2}", firstInput, secondInput, firstInput - secondInput);
            else if ((operationChar == 'x') || (operationChar == '*'))
                Console.WriteLine("{0} * {1} = {2}", firstInput, secondInput, firstInput * secondInput);
            else if (operationChar == '/')
                Console.WriteLine("{0} / {1} = {2}", firstInput, secondInput, firstInput / secondInput);
            else
                Console.WriteLine("Wrong Character");

        }
    }
}

