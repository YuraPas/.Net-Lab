using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2
{
    static class ColorExtentions
    {

        /// <summary>
        /// Sorting enum element in ascending orde
        /// </summary
        /// <param name="color"></param>
        public static void ColorSortExtention(this Color color)
        {
            var items = Enum.GetValues(enumType: typeof(Color));
            Array.Sort(items);
            foreach (int item in items)
            {

                Console.WriteLine($"{item} equals to {(Color)item} ");
            }
        }
    }
    internal enum Color
    {
        Red = 4, Blue = 15, Green = 1
    }
    public class Task4 : IRunnable
    {

        public void Run()
        {

            Color check = new Color();
            check.ColorSortExtention();
        }
    }
}
