using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex91
{
    class Program
    {
static void Main(string[] args)
{
    List<int> list = new List<int> { 12, 34, 56, 88, 33, 11 };
    List<int> list3 = list.FindAll(delegate(int x) { return x % 2 == 0; });
    foreach (int item in list3)
    {
        Console.WriteLine(item);
    }
}
    }
}
