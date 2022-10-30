
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;

namespace EDUJ;
public class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "Poniedziałek");
        dictionary.Add(2, "Wtorek");
        dictionary.Add(3, "środa");
        dictionary.Add(0, "środa");
        dictionary.TryAdd(3, "Środa");

        //Console.WriteLine(dictionary[1]);
        foreach (var item in dictionary)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();

        sortedDictionary.Add(5, "Piątek");
        sortedDictionary.Add(2, "Wtorek");
        sortedDictionary.Add(4, "Poniedziałek");
        sortedDictionary.Add(1, "Poniedziałek");

        foreach (var item in sortedDictionary)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

    }
}











