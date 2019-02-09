using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson3
{

    //IDrawable is declared in Task1 as a IDrawableFigure interface


    public class Task4 : IRunnable
    {
        public static void DrawAll(params IDrawableFigure[] array)
        {
            foreach (var element in array)
            {
                element.Draw();
            }
        }
        public void Run()
        {
            FigureVirtual figure = new FigureVirtual();
            Square square = new Square();
            Rectangle rectangle = new Rectangle();

            DrawAll(figure, square, rectangle);
            Console.ReadKey();
        }
    }
}