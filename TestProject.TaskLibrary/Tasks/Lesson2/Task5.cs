using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2
{
    internal enum LongRange : long
    {
        Max = 9223372036854775807, Min = -9223372036854775808
    }
    public class Task5 : IRunnable
    {
        public void Run()
        {
            Console.WriteLine((long)LongRange.Max); // max number
            Console.WriteLine((long)LongRange.Min); // min number        
        }
        }
}
