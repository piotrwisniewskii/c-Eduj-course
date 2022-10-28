
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
        Thread t1 = new Thread(new ParameterizedThreadStart(LongMethod));
        Thread t2 = new Thread(new ParameterizedThreadStart(LongMethod));
        t1.Start(50);
        t2.Start(50);
    }

    static void LongMethod(object n)
    {
        for (int i = 0; i < (int)n; i++)
        {
            Console.WriteLine($" ID {Thread.CurrentThread.ManagedThreadId}: {i}");
        }
    }
}






