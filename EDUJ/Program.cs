
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
        HashSet<string> hs = new HashSet<string>();
        hs.Add("Poniedziałek");
        hs.Add("Wtorek");
        hs.Add("Wtorek");
        hs.Add("Środa");
        hs.Add("Czwartek");
        hs.Add("Piątek");
        hs.Add("Piątek");
        hs.Add("Piątek");

        Console.WriteLine(hs.Contains("Poniedziałek"));
        Console.WriteLine(hs.Contains("Niedziela"));
        Console.WriteLine("\nHashSet - Ilość " + hs.Count);

        foreach (var item in hs)
        {
            Console.WriteLine(item);
        }

        SortedSet<string> ss = new SortedSet<string>();
        ss.Add("Piątek");
        ss.Add("Sobota");
        ss.Add("Niedziela");
        ss.Add("Niedziela");
        ss.Add("Niedziela");
        ss.Add("Niedziela");

        Console.WriteLine("\nSortedSet - Ilość " + ss.Count);

        foreach (var item in ss)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nOperacje:");

        hs.UnionWith(ss); // połączenie
        hs.ExceptWith(ss); // usunięcie
        hs.Intersect(ss); // część wspólna
        hs.SymmetricExceptWith(ss); // częśc wspołna 2 zbiorów z wykluczeniem powtórzeń

        foreach (var item in hs)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\nHashSet - Ilość " + hs.Count);
        Console.WriteLine(hs.IsSubsetOf(hs));
        Console.WriteLine(hs.IsSupersetOf(ss));


    }

    
}






