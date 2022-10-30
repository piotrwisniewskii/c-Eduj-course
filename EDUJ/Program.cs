
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;

namespace EDUJ;
public class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Ilosc " + stack.Count());
        stack.Pop();
        Console.WriteLine();
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Ilosc " + stack.Count());
    }
}











