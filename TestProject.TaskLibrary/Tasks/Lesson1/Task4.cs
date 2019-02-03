using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    class Task4 : IRunnable
    {
        static class Rectangle
        {
            public static double _xPointLeftFirst;
            public static double _xPointLeftSecond;

            public static double _yPointLeftFirst;
            public static double _yPointLeftSecond;

           


            public static double CalculatePerimeter(double xPointLeftFirst, double yPointLeftFirst, double xPointLeftSecond, double yPointLeftSecond)
            {
                return 2 * ((xPointLeftSecond - xPointLeftFirst) + (yPointLeftSecond - yPointLeftFirst));
            }

            public static double CalculateSquare(double xPointLeftFirst, double yPointLeftFirst, double xPointLeftSecond, double yPointLeftSecond)
            {
                return (xPointLeftSecond - xPointLeftFirst) * (yPointLeftSecond - yPointLeftFirst);
            }
        }

        public void Run()
        {
            Rectangle._xPointLeftFirst = 4;
            Rectangle._yPointLeftFirst = 2;
            Rectangle._xPointLeftSecond = 10;
            Rectangle._yPointLeftSecond = 0;
            Rectangle.CalculatePerimeter(Rectangle._xPointLeftFirst, Rectangle._yPointLeftFirst, Rectangle._xPointLeftSecond, Rectangle._yPointLeftSecond);
        }
    }
}
