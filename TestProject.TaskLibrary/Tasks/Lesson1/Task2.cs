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


            public void CalculatePerimeter(double xPointLeftFirst, double yPointLeftFirst, double xPointLeftSecond, double yPointLeftSecond)
            {
                perimether = ((xPointLeftSecond - xPointLeftFirst) + (yPointLeftSecond - yPointLeftFirst));
            }

            public void CalculateSquare(double xPointLeftFirst, double yPointLeftFirst, double xPointLeftSecond, double yPointLeftSecond)
            {
                square =  (xPointLeftSecond - xPointLeftFirst) * (yPointLeftSecond - yPointLeftFirst);
            }
        }


        public void Run()
        {
            Rectangle rectInstance = new Rectangle(4, 2, 10, 0);
            Console.WriteLine($"Rectangle perimether equals: {rectInstance.perimether}" );
            
            Console.Write($"Rectangle square equals:{rectInstance.square} ");
            
        }
    }
}
