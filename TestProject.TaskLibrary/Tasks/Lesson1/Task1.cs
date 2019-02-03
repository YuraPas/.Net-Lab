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

           
            public  double CalculatePerimeter(double xPointLeftFirst, double yPointLeftFirst, double xPointLeftSecond, double yPointLeftSecond)
            {
                return 2 * ((xPointLeftSecond - xPointLeftFirst) + (yPointLeftSecond - yPointLeftFirst));
            }

            public double CalculateSquare(double xPointLeftFirst, double yPointLeftFirst, double xPointLeftSecond, double yPointLeftSecond)
            {
                return (xPointLeftSecond - xPointLeftFirst) * (yPointLeftSecond - yPointLeftFirst);
            }
        }

        
        public void Run()
        {
            Rectangle rectInstance = new Rectangle(4, 2, 10, 0);
            Console.Write("Rectangle perimether equals: ");
            Console.WriteLine(CalculatePerimeter(rectInstance._xPointLeftFirst, rectInstance._yPointLeftFirst, rectInstance._xPointLeftSecond, rectInstance._yPointLeftSecond));


            Console.Write("Rectangle square equals: ");
            Console.WriteLine(CalculateSquare(rectInstance._xPointLeftFirst, rectInstance._yPointLeftFirst, rectInstance._xPointLeftSecond, rectInstance._yPointLeftSecond));

        }



    }
}
