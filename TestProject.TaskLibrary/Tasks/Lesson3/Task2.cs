using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3
{
    public class PointFigure
    {

        public int X { get; private set; }
        public int Y { get; private set; }

        public PointFigure(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
    public class PointSquare : PointFigure
    {
        public PointSquare(int X, int Y) : base(X, Y)
        {

        }

    }
    public class Task2 : IRunnable
    {
        public void Run()
        {
            PointSquare pointSquare = new PointSquare(5, 10);
            Console.WriteLine($"X point:{pointSquare.X} Y point:{pointSquare.Y}");
        }
    }

}