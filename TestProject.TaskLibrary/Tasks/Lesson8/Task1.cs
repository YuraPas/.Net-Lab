using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson8
{

    #region Interfaces declaration

    internal interface IDrawable
    {
        void Draw();
    }

    internal interface IMovable
    {
        void MoveLeft(ConsoleRectangle rect);
        void MoveRight(ConsoleRectangle rect);
        void MoveUp(ConsoleRectangle rect);
        void MoveDown(ConsoleRectangle rect);
    }

    internal interface IPrinter
    {
        void Print(string printString);
        ConsoleKey ReadInput();
    }


    #endregion

    public class ConsolePrinter : IPrinter
    {
        public void Print(string printString)
        {
            Console.WriteLine(printString);
        }

        public ConsoleKey ReadInput()
        {
            return Console.ReadKey(false).Key;
        }
    }


    public class Point
    {
        public int X;
        public int Y;
    }

    public class ConsoleRectangle : IDrawable, IMovable
    {
        #region Property declaration

        public int Width { get; set; }
        public int Height { get; set; }

        public Point Location { get; set; }


        #endregion

        #region Constructor

        public ConsoleRectangle(int width, int height, Point location)
        {
            Width = width;
            Height = height;
            Location = location;
        }

        public ConsoleRectangle(int width, int height) : this(width, height, new Point())
        {

        }

        #endregion



        public void Draw()
        {
            char drawSymbol = '+';
            string outputString = "+";
            string space = "";
            string temp = "";

            for (int i = 0; i < Width; i++)
            {
                space += " ";
                outputString += drawSymbol;
            }

            for (int j = 0; j < Location.X; j++)
                temp += " ";

            outputString += drawSymbol + "\n";

            for (int i = 0; i < Height; i++)
                outputString += temp + drawSymbol + space + "+" + "\n";

            outputString += temp + drawSymbol;
            for (int i = 0; i < Width; i++)
                outputString += drawSymbol;

            outputString += drawSymbol + "\n";


            Console.CursorTop = Location.Y;
            Console.CursorLeft = Location.X;
            Console.Write(outputString);


        }

        public ConsoleRectangle Resize(int x, int y)
        {
            return new ConsoleRectangle(x, y);
        }

        #region IMovable interface operations

        public void MoveLeft(ConsoleRectangle rect)
        {
            if (rect.Location.X == 0)
            {
                Console.WriteLine("Cant go out of border");
                return;
            }

            rect.Location.X--;
            rect.Draw();
        }

        public void MoveRight(ConsoleRectangle rect)
        {
            rect.Location.X++;
            rect.Draw();
        }

        public void MoveUp(ConsoleRectangle rect)
        {
            if (rect.Location.Y == 0)
            {
                Console.WriteLine("Cant go higher");
                return;
            }

            rect.Location.Y--;
            rect.Draw();
        }

        public void MoveDown(ConsoleRectangle rect)
        {
            rect.Location.Y++;
            rect.Draw();
        }

        #endregion
    }
    public class Task1 : IRunnable
    {
        private static void Move(ConsoleKey input, ConsoleRectangle rect)
        {
            switch (input)
            {
                case ConsoleKey.Escape:
                    return;
                case ConsoleKey.UpArrow:
                    rect.MoveUp(rect);
                    break;

                case ConsoleKey.DownArrow:
                    rect.MoveDown(rect);
                    break;

                case ConsoleKey.LeftArrow:
                    rect.MoveLeft(rect);
                    break;

                case ConsoleKey.RightArrow:
                    rect.MoveRight(rect);
                    break;
                case ConsoleKey.R:
                    Console.Write("Width: ");
                    int width = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Height: ");
                    int height = Convert.ToInt32(Console.ReadLine());

                    rect = rect.Resize(width, height);
                    Console.Clear();
                    rect.Draw();
                    break;

            }
        }

   

        public void Run()
        {
            Console.SetWindowSize(110, 35);
            ConsolePrinter printer = new ConsolePrinter();

            // X and Y will initially be set to 0,0 ;
            // Create new Instance of Point to modify
            ConsoleRectangle rect = new ConsoleRectangle(10, 5, new Point());
            rect.Draw();


            while (true)
            {
                var inputChar = printer.ReadInput();
                Console.Clear();
                Move(inputChar, rect);    
            }
        }
    }
}




