using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex5
{
class ToolsIntList
{
    public static List<int> GetNewList(List<int> list)
    {

        List<int> list2 = new List<int>();
        foreach (int item in list)
        {
            if (item % 2 == 0)
                list2.Add(item);
        }
        return list2;
    }
}


class Program
{
    
    static void Main(string[] args)
    {
        List<int> list = new List<int> { 12, 34, 56, 88, 33, 11 };
            
        foreach (int item in ToolsIntList.GetNewList(list))
        {
            Console.WriteLine(item);
        }
    }
}
}
