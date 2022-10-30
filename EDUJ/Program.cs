
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;

namespace EDUJ;
public class Program
{
    static void Main(string[] args)
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Poniedziałek");
        queue.Enqueue("Wtorek");
        queue.Enqueue("Środa");

        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"\n{queue.Count}");
        Console.WriteLine(queue.First());
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Count());
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(queue.Peek());
    }
}











