using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3
{

    public class FigureVirtual : IDrawableFigure
    {
        public virtual void Draw()
        {
            Console.WriteLine("Method Draw from base FigureVirtual class");
        }

    }


    public class Task3 : IRunnable
    {

        public void Run()
        {
            FigureVirtual figureVirtual = new FigureVirtual();
            Square square = new Square();
            Rectangle rectangle = new Rectangle();

            figureVirtual.Draw();
            square.Draw();
            rectangle.Draw();
        }
    }
}