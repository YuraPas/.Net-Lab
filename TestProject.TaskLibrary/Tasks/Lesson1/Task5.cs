using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson1
{
    class Task5 : IRunnable
    {
        public struct Complex
        {
            #region property and user constructor declaration
            public double Real { get; }
            public double Imaginary { get; }

            public Complex(double real, double imaginary)
            {
                Real = real;
                Imaginary = imaginary;
            }
            #endregion

            #region Multiplication operator overloading for complex numbers
            public static Complex operator * (Complex firstNumber, Complex secondNumber)
            {
                return new Complex(firstNumber.Real * secondNumber.Real + Math.Abs(firstNumber.Imaginary * secondNumber.Imaginary),
                                            firstNumber.Real * secondNumber.Imaginary + firstNumber.Imaginary * secondNumber.Real);
            }

            #endregion
            #region Division operator overloading for complex numbers

            public static Complex operator / (Complex firstNumber, Complex secondNumber)
            {
                Complex buffer = firstNumber * secondNumber;
                double productRes = Math.Pow(secondNumber.Real, 2) + Math.Abs(Math.Pow(secondNumber.Real, 2));
                return new Complex(buffer.Real / productRes, buffer.Imaginary / productRes);

            }
            #endregion
        }


        public void Run()
        {
            Complex firstInstance = new Complex(5, 2);
            Complex secondInstance = new Complex(4, 3);
            Complex multiplicationResult = firstInstance * secondInstance;
            Complex divisionResult = firstInstance * secondInstance;
            //output each instance properties


        }
    }
}
