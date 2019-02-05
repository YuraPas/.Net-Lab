using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    public class Task2 : IRunnable
    {
        class Rectangle
        {
            public double _xPointLeftFirst;
            public double _xPointLeftSecond;

            public double _yPointLeftFirst;
            public double _yPointLeftSecond;

            public double perimether { get; set; } = 0;
            public double square { get; set; } = 0;


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
            public void CalculatePerimeter(double xPointLeftFirst, double yPointLeftFirst, double xPointLeftSecond, double yPointLeftSecond)
            {
                perimether = ((xPointLeftSecond - xPointLeftFirst) + (yPointLeftFirst - yPointLeftSecond));
            }
            /// <summary>
            /// Method for calculating Square of Rectangle based on 2 points
            /// </summary>
            /// <param name="xPointLeftFirst"></param>
            /// <param name="yPointLeftFirst"></param>
            /// <param name="xPointLeftSecond"></param>
            /// <param name="yPointLeftSecond"></param>
            /// <returns></returns>
            public void CalculateSquare(double xPointLeftFirst, double yPointLeftFirst, double xPointLeftSecond, double yPointLeftSecond)
            {
                square = (xPointLeftSecond - xPointLeftFirst) * (yPointLeftFirst - yPointLeftSecond);
            }

            /// <summary>
            /// Hiding logic of Initializing Perimeter and Square auto-properties via this template method pattern
            /// </summary>
            public void PropertyInitializer()
            {
                CalculatePerimeter(this._xPointLeftFirst, this._yPointLeftFirst, this._xPointLeftSecond, this._yPointLeftSecond);
                CalculateSquare(this._xPointLeftFirst, this._yPointLeftFirst, this._xPointLeftSecond, this._yPointLeftSecond);

            }
        }

        public void Run()
        {
            Rectangle rectInstance = new Rectangle(4, 2, 10, 0);
            rectInstance.PropertyInitializer();
            Console.WriteLine($"Rectangle perimether equals: {rectInstance.perimether}");

            Console.Write($"Rectangle square equals:{rectInstance.square}");
        }
    }
}
