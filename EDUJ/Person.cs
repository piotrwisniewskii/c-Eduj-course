using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUJ
{
    public class Person
    {
        public string name;
        public int age;
        public static int count = 0;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            count++;
        }

        public void Hello()
        {
            Console.WriteLine($"Cześć jestem {name} i mam {age} lat. Jest nas {count}");
            Count();
        }

        public static void Count()
        {
            Console.WriteLine($"Jest nas: {count}");

        }
    }
}
