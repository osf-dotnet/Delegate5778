using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1
{
    public delegate int someDelegate(int x, int y);
    class Program
    {
        static public int sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static void Main(string[] args)
        {
            someDelegate myDelegate = new someDelegate(sum);
            int x = myDelegate(1, 1);
            Console.WriteLine(x);         
        }
    }

}
