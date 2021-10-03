using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex4
{ 
public delegate int someDelegate(int x, int y);
class Program
{
       

    static public int sum(int num1, int num2)
    {
        return num1 + num2;
    }
    static public int mult(int num1, int num2)
    {
        return num1 * num2;
    }
    static void Main(string[] args)
    {
        someDelegate myDelegate = sum;
        myDelegate += mult;
        myDelegate -= sum;
        foreach (Delegate d in myDelegate.GetInvocationList())
            Console.WriteLine(d.Method);
    }
}    

}
