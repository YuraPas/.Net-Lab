using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Csharp_Udemy_Course.ConditionalStatements
{
    class Task4_5 : IRunnable
    {
        public void Run()
        {
            // #4

            int checkYear;
            
            Console.Write("Input an year : ");
            checkYear = Convert.ToInt32(Console.ReadLine());

            if ((checkYear % 400) == 0)
                Console.WriteLine("{0} is a leap year.\n", checkYear);
            else if ((checkYear % 100) == 0)
                Console.WriteLine("{0} is not a leap year.\n", checkYear);
            else if ((checkYear % 4) == 0)
                Console.WriteLine("{0} is a leap year.\n", checkYear);
            else
                Console.WriteLine("{0} is not a leap year.\n", checkYear);




            // #5

            int inputAge;
 
            inputAge = Convert.ToInt32(Console.ReadLine());
            if (inputAge < 18)
            {
                Console.Write("Sorry, You are not eligible to caste your vote.\n");
                Console.Write($"You would be able to caste your vote after {18 - inputAge} year.\n\n");
            }
            else
                Console.Write("Congratulation! You are eligible for casting your vote.\n\n");
        }
    }
}
