using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2
{
    public class Task3 : IRunnable, IPrinter
    {
        public enum YearPeriod : int
        {
            Winter = 0, Spring, Summer, Autumn
        }
        /// <summary>
        /// Method that ouputs period of year according to user input
        /// 0 for Winter; 1 for Sprint; 2 for Summer; 3 for Autumn
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        public static YearPeriod OuputYearPeriod(int choice)
        {
            switch (choice)
            {
                case 0:
                    return YearPeriod.Winter;
                case 1:
                    return YearPeriod.Spring;
                case 2:
                    return YearPeriod.Summer;
                default:
                    return YearPeriod.Autumn;

            }

        }


        public void Run()
        {
            int userInput = Read();
            while (userInput > 4 || userInput < 0)
            {
                userInput = Convert.ToInt32(Console.ReadLine());
            }
            //todo : put the process of user input into another method
            Print(OuputYearPeriod(userInput));
        }

        public void Print(object message)
        {
            Console.WriteLine(message.ToString());
        }

        public int Read()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
