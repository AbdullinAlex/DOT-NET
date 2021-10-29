using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdullin01
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
