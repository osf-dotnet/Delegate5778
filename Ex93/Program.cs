using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex93
{
    public delegate int someDelegate(int x, int y);

    class Program
    {     
        static void Main(string[] args)
        {
            someDelegate myDelegate = (x, y) => x + y;
            Console.WriteLine(myDelegate(1, 1));
        }
    }
}
