using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3
{

    public interface IDrawableFigure
    {
        void Draw();
    }
    // Using IFigure interface instead Figure abstract class
    // so i can complete Task 3 without code duplicate

    public abstract class Figure
    {
        public abstract void Draw();
    }

    public class Square : FigureVirtual, IDrawableFigure
    {
        public override void Draw()
        {
            Console.WriteLine("Method Draw from Square class");
        }
    }

    public class Rectangle : FigureVirtual, IDrawableFigure
    {
        public override void Draw()
        {
            Console.WriteLine("Method Draw from Rectangle class");
        }
    }

    public class Task1 : IRunnable
    {

        public void Run()
        {
            Square square = new Square();
            Rectangle rectangle = new Rectangle();

            square.Draw();
            rectangle.Draw();


        }
    }
}