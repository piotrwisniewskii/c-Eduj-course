
using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;

namespace EDUJ;
public class Program
{
    static void Main(string[] args)
    {
        SortedList<int, string> sl = new SortedList<int, string>();
        sl.Add(1, "Poniedziałek");
        sl.Add(2, "Wtorek");
        sl.Add(3, "Środa");
        sl.Add(4, "Czwartek");
        sl.Add(5, "Piątek");
        foreach (KeyValuePair<int,string> item in sl)
        {
            Console.WriteLine(item.Key + " - " + item.Value);
        }
        Console.WriteLine("---------");
        Console.WriteLine(sl[1]);
        Console.WriteLine(sl.Values[0]);
        foreach (var item in sl.Keys)
        {
            Console.WriteLine(item);
        }
    }
}











