using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson2
{
    public class Task2 : IRunnable
    {
        internal interface ISize
        {
            double Width { get; set; }
            double Height { get; set; }

            double Perimeter();

        }

        internal interface ICoordinates
        {

            double X { get; set; }
            double Y { get; set; }
        }


        struct Rectangle : ISize, ICoordinates
        {
            public double Height { get; set; }
            public double Width { get; set; }

            public double X { get; set; }
            public double Y { get; set; }


            public Rectangle(double Height, double Width, double xPoint, double yPoint)
            {
                this.Height = Height;
                this.Width = Width;
                X = xPoint;
                Y = yPoint;
            }

            public double Perimeter()
            {
                return 2 * (Width + Height);
            }
        }

        public void Run()
        {

            //throw new NotImplementedException();
        }
    }
}
