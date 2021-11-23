using System;

namespace Abdullin03
{
    public interface IPrinter
    {
        void Print(string str);
    }
    public class ConsolePrinter : IPrinter
    {
        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}