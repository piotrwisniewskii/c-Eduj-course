
using System;

//namespace EDUJ;
//public class Program
//{
//    static void Main(string[] args)
//    {
//        Random rnd = new Random();
//        int random = rnd.Next(1, 11);
//        int user = 0;
//        bool valid = false;
//        int i = 0;
//        bool[] array = new bool[10];

//        Console.Title = "Zgadnij Liczbę!";
//        Console.ForegroundColor = ConsoleColor.Cyan;
//        Console.WriteLine("Witoj Marto...To jest gra która stworzyłem, żebyś już nigdy przenigdy wieęcej się nie nudziła...");
//        Console.WriteLine("W grzej tej musisz zgadnąć liczbę od 1 do 10...program będzie Ciebie prowadził krok po kroku jak to zrobić, na koniec zliczę wszystkie nieudane próby...możesz wygrać wspaniałę nagrody\n ale uważaj!");
//        Console.ForegroundColor = ConsoleColor.Yellow;
//        Console.WriteLine("przegrana może Cię słono kosztować....,");
//        Console.WriteLine("masz trzy próby...");



//        do
//        {
//            do
//            {
//                Console.WriteLine("podaj liczbę od 1 do 10");
//                valid = int.TryParse(Console.ReadLine(), out user);
//                if (!valid)
//                {
//                    Console.ForegroundColor = ConsoleColor.Red;
//                    Console.WriteLine("błędna liczba!");
//                    Console.ResetColor();
//                }
//            } while (!valid);

//            if (user < 1 || user > 10)
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("liczba poza zakresem Pao durna kochana ty moja");
//                Console.ResetColor();
//                continue;
//            }

//            if (array[user - 1])
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("próbowałaś już z tą liczbą kotku...");
//                Console.ResetColor();
//                continue;
//            }
//            else
//            {
//                array[user - 1] = true;
//            }

//            if (random < user)
//            {
//                Console.ForegroundColor = ConsoleColor.DarkMagenta;
//                Console.WriteLine("za wysoko....");
//                Console.ResetColor();
//            }
//            else if (random > user)
//            {
//                Console.ForegroundColor = ConsoleColor.DarkMagenta;
//                Console.WriteLine("za nisko");
//                Console.ResetColor();
//            }
//            i++;
//        } while (user != random);

//        if (i < 3)
//        {
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine("Brawo!, wygrałaś buziaka");
//            Console.ResetColor();

//        }
//        if (i > 3)
//        {
//            Console.ForegroundColor = ConsoleColor.DarkRed;
//            Console.WriteLine(" Ponad 3 próby, Robisz Kanapki :(");
//            Console.ResetColor();
//        }

//        Console.ReadKey();



//    }
//}






