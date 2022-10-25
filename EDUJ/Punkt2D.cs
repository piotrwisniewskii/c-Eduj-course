using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUJ
{
    public class Punkt2D
    {
        public int x;
        public int y;

        public static Punkt2D operator + (Punkt2D a, Punkt2D b)
        {
            return new Punkt2D(a.x + b.x, a.y + b.y);   
        }
        public static Punkt2D operator +(Punkt2D a, int b)
        {
            return new Punkt2D(a.x + b, a.y + b);
        }
        public Punkt2D(int x,int y)
        {
           this.x = x;
           this.y = y;
        }
        public void Show()
        {
            Console.WriteLine($"x = {x}, y = {y}");
        }
    }
}
