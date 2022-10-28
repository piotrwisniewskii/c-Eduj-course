
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
        try
        {

            StreamWriter sw = new StreamWriter("../../../file.txt", true);
            sw.WriteLine(Console.ReadLine());
            sw.Close();

            Console.WriteLine("\nZawartość pliku:");
            StreamReader sr = new StreamReader("../../../file.txt");

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            sr.Close();
        }
        catch (Exception ex)
        { 
            Console.WriteLine(ex.Message);
        }
        
    }
}






