
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Net.Security;
using System.Security.Cryptography;
using System.Text;


namespace EDUJ;
public class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 2, 5, -10, 7, 0, 1, 2, 1, 9, -5 };

        arr = arr.Where(x => x > 0).Select(x => x * 2).ToArray();

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine($"First = {arr.FirstOrDefault()}"); // pierwsza lub domyślna wartość
        Console.WriteLine($"Sum ={arr.Sum()}"); // suma
        Console.WriteLine($"Avg = {arr.Average()}"); // srednia 
        Console.WriteLine($"Max = {arr.Max()}");
        Console.WriteLine($"Min = {arr.Min()}");
    
    }
}






