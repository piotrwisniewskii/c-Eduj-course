
using System;
using System.Collections;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Net.Security;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;


namespace EDUJ;
public class Program
{
    static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList(5);
        arrayList.Add(5);
        arrayList.Add(15);
        arrayList.Add(-5);
        arrayList.Add(10);
        arrayList.Remove(5);
        arrayList.RemoveAt(1);

        arrayList.Sort();
        arrayList.Reverse();
        arrayList.Clear();
        Console.WriteLine("Ilość elementów: " + arrayList.Count);
        //Console.WriteLine(arrayList[0]);
        //Console.WriteLine(arrayList[1]);
        Animal Kot = new Animal("Diana", 1);
        arrayList.Insert(0, Kot);
        Console.WriteLine("Ilość elementów: " + arrayList.Count);
        foreach (var item in arrayList)
        {
            
            if ( item is Animal)
            {
                Console.WriteLine(((Animal)item).name);
               
                    
            }
            Console.WriteLine(item);
        }
    }
}

class Testtt
{
    public void SayHi()
    {
        Console.WriteLine("Hello!");
    }
}






