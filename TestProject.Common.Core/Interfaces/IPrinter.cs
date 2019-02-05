using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Common.Core.Interfaces
{
    public interface IPrinter
    {
        void Print(string message);
        int Read();
    }
}
