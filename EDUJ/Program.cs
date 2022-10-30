
using System.ComponentModel;

namespace EDUJ;
public class Program
{
    static void Main(string[] args)
    {
        List<Kotki> kotki = new List<Kotki>();
        Kotki Diana = new Kotki("Diana", 10, 30);
        Kotki Dio = new Kotki("Dio", 100, 20000);
        Kotki Leo = new Kotki("Leo", 20, 200);
        Kotki Bobek = new Kotki("Bobek", 1, 1);
        Kotki Miałczyńsk = new Kotki("Miałczyńska", 110, 30);
        Kotki KotaZewnetrzna = new Kotki("KotaZewnetrzna", 100, 100);
        kotki.Add(Diana);
        kotki.Add(Dio);
        kotki.Add(Leo);
        kotki.Add(Bobek);
        kotki.Add(Miałczyńsk);
        kotki.Add(KotaZewnetrzna);
       
        foreach (Kotki kotek in kotki)
        {
            
            Console.WriteLine(kotek.Name);
            
        }

        Random random = new Random();
        
        
        
        Console.WriteLine($"Pierwsza Walka!{Dio.Name} kontra {Leo.Name}");
        do
        {
            int atak = random.Next(1, 10);
            if (Leo.Zycie > 0)
            {
                Dio.Attack(Leo, atak);
                
            }
            else
                Console.WriteLine("Leo Ucieka w popłochu!");
            if(Dio.Zycie > 0)
            {
                Leo.Attack(Dio, atak);
            }
            else
                Console.WriteLine("Dio Ucieka w popłochu!");

        } while (Dio.Zycie > 0 && Leo.Zycie > 0);
        Console.WriteLine($"Walka zakonczona Dio : {Dio.Zycie} Leo : {Leo.Zycie} ");
       




    }

    public class Kotki
    {
        public string Name { get; set; }
        public int Sila { get; set; }
        public int Zycie { get; set; }

        public Kotki(string name, int sila, int zycie)
        {
            Name = name;
            Sila = sila;
            Zycie = zycie;
        }

        public int Attack(Kotki kotek, int dmg)
        {
            kotek.Zycie -= dmg;
            Console.WriteLine($"Oh nie {kotek.Name} oberwał za {dmg} i ma aktualnie {kotek.Zycie}");
            return kotek.Zycie;
        }

        public void SayHi()
        {
            Console.WriteLine("Helo");
        }

    }
}











