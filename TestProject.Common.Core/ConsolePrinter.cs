using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject
{
    public class ConsolePrinter : IPrinter
    {
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
