using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex94
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> myDelegate = (x, y) => x + y;
            Console.WriteLine(myDelegate(1, 1));
        }

    }
}
