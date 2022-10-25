
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
        CalcWithText(Add, 2, 5);

    }

    static void CalcWithText(Func<int,int,int> func, int a,int b)
    {
        int res = func(a, b);
        Console.WriteLine($"Wynik = {res}");
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
    
}






