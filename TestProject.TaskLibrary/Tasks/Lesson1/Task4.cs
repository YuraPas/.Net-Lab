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


            /// <summary>
            /// Calculater Perimiter with two points given as paramethers
            /// </summary>
            /// <param name="xPointLeftFirst"></param>
            /// <param name="yPointLeftFirst"></param>
            /// <param name="xPointLeftSecond"></param>
            /// <param name="yPointLeftSecond"></param>
            /// <returns></returns>
            public static double CalculatePerimeter(double xPointLeftFirst, double yPointLeftFirst, double xPointLeftSecond, double yPointLeftSecond)
            {
                return 2 * ((xPointLeftSecond - xPointLeftFirst) + (yPointLeftFirst - yPointLeftSecond));
            }
            /// <summary>
            /// Calculater Square with two points given as paramethers
            /// </summary>
            /// <param name="xPointLeftFirst"></param>
            /// <param name="yPointLeftFirst"></param>
            /// <param name="xPointLeftSecond"></param>
            /// <param name="yPointLeftSecond"></param>
            /// <returns></returns>
            public static double CalculateSquare(double xPointLeftFirst, double yPointLeftFirst, double xPointLeftSecond, double yPointLeftSecond)
            {
                return (xPointLeftSecond - xPointLeftFirst) * (yPointLeftFirst - yPointLeftSecond);
            }
        }

        public void Run()
        {
            Rectangle._xPointLeftFirst = 4;
            Rectangle._yPointLeftFirst = 2;
            Rectangle._xPointLeftSecond = 10;
            Rectangle._yPointLeftSecond = 0;
            double result = Rectangle.CalculatePerimeter(Rectangle._xPointLeftFirst, Rectangle._yPointLeftFirst, Rectangle._xPointLeftSecond, Rectangle._yPointLeftSecond);
            Console.WriteLine(result);
        }
    }
}
