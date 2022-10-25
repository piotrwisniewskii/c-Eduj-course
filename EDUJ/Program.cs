
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Net.Security;
using System.Security.Cryptography;
using System.Text;

namespace EDUJ;
public class Program
{

    public delegate int CalcDelegate(int a, int b);
    public delegate string StringDelegate(string a);

    static void Main(string[] args)
    {
        CalcDelegate calcDelegate = Add;
        CalcWithText(calcDelegate.Invoke, 2, 5);

        StringDelegate stringDelegate = Hello;
        PrzywitajSie(stringDelegate.Invoke, "siemano");

        string czesc = "ELO";
        StringDelegate stringDelegate2 = delegate (string czesc)
        {
            return "hello";
        };
        PrzywitajSie(stringDelegate2.Invoke, czesc);
        Console.WriteLine(stringDelegate2.Invoke(czesc));
        CalcDelegate calcDelegate2 = delegate (int a, int b) // metoda ANONIMOWA tzn. "jednorazowa"
        { 
            return a + b;
        };
        Console.WriteLine(calcDelegate2.Invoke(2,5));
        CalcWithText(calcDelegate2.Invoke, 2, 5);


        string a = "turur";
        StringDelegate stringo = delegate (string a)
        {
            return a;
        };
        Console.WriteLine(stringo.Invoke(a));

        Func<int, int, int> funcDelegate = Add;
        CalcWithText(funcDelegate.Invoke, 2, 5);

        Action<int, int> action = delegate (int a, int b)
        {
            Console.WriteLine(a + b);
        };

        Predicate<int> predicate = delegate (int a)
        {
            return a == 0;
        };
        Console.WriteLine(predicate.Invoke(5));
        Console.WriteLine(predicate.Invoke(0));
    }

    static void CalcWithText(Func<int, int, int> func, int a, int b )
    {
        int res = func.Invoke(2, 5);
        Console.WriteLine($"Wynik = {res}");
    }

    static void PrzywitajSie(Func<string, string>func, string czesc)
    {
        string h = func.Invoke(czesc);
    }

    static string Hello(string czesc)
    {
        return czesc;
    }


    static int Add(int a,int b)
    {
        return a + b;
    }

    
    
}






