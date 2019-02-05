using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public class Task1 : IRunnable
    {
        class Rectangle
        {
            public double _xPointLeftFirst;
            public double _xPointLeftSecond;

            public double _yPointLeftFirst;
            public double _yPointLeftSecond;

            public Rectangle(double xPointLeftFirst, double yPointLeftFirst, double xPointLeftSecond, double yPointLeftSecond)
            {
                _xPointLeftFirst = xPointLeftFirst;
                _yPointLeftFirst = yPointLeftFirst;
                _xPointLeftSecond = xPointLeftSecond;
                _yPointLeftSecond = yPointLeftSecond;

            }

            /// <summary>
            /// Method for calculating perimether of Rectangle based on 2 points
            /// </summary>
            /// <param name="xPointLeftFirst"></param>
            /// <param name="yPointLeftFirst"></param>
            /// <param name="xPointLeftSecond"></param>
            /// <param name="yPointLeftSecond"></param>
            /// <returns></returns>
            public double CalculatePerimeter(double xPointLeftFirst, double yPointLeftFirst, double xPointLeftSecond, double yPointLeftSecond)
            {
                return 2 * ((xPointLeftSecond - xPointLeftFirst) + (yPointLeftFirst - yPointLeftSecond));
            }
            /// <summary>
            /// Method for calculating Square of Rectangle based on 2 points
            /// </summary>
            /// <param name="xPointLeftFirst"></param>
            /// <param name="yPointLeftFirst"></param>
            /// <param name="xPointLeftSecond"></param>
            /// <param name="yPointLeftSecond"></param>
            /// <returns></returns>
            public double CalculateSquare(double xPointLeftFirst, double yPointLeftFirst, double xPointLeftSecond, double yPointLeftSecond)
            {
                return (xPointLeftSecond - xPointLeftFirst) * (yPointLeftFirst - yPointLeftSecond);
            }
        }


        public void Run()
        {
            Rectangle rectInstance = new Rectangle(4, 2, 10, 0);
            Console.Write("Rectangle perimether equals: ");
            Console.WriteLine(rectInstance.CalculatePerimeter(rectInstance._xPointLeftFirst, rectInstance._yPointLeftFirst, rectInstance._xPointLeftSecond, rectInstance._yPointLeftSecond));


            Console.Write("Rectangle square equals: ");
            Console.WriteLine(rectInstance.CalculateSquare(rectInstance._xPointLeftFirst, rectInstance._yPointLeftFirst, rectInstance._xPointLeftSecond, rectInstance._yPointLeftSecond));

        }



    }
}
