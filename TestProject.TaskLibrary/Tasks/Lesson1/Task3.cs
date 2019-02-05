using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;


namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    class Task3 : IRunnable
    {
        internal class Circle
        {
            private const double pi = 3.14;
            public int _radius;

            public Circle(int radius)
            {
                _radius = radius;
            }
            //length of circle = 2*pi*R
            //square of circle = pi*R^2

            /// <summary>
            /// Calculates circle lenght with given radius
            /// </summary>
            /// <param name="radius"></param>
            /// <returns></returns>
            public double ComputeLenght(double radius)
            {
                return 2 * pi * radius;

            }
            /// <summary>
            /// Calculates circle square with given radius
            /// </summary>
            /// <param name="radius"></param>
            /// <returns></returns>
            public double ComputeSquare(double radius)
            {
                return pi * radius * radius;
            }
        }

        public void Run()
        {
            Circle circle = new Circle(5);
            Console.WriteLine(circle.ComputeLenght(circle._radius));
            Console.WriteLine(circle.ComputeSquare(circle._radius));
        }
    }
}

