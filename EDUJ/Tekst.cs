using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUJ
{
    public class Tekst
    {
        char[] tekst;
        
        public char this[int n]
        {
            get
            {
                return tekst[n];
            }
            set
            {
                tekst[n] = value;
            }
        }

        public char this [string n]
        {
            get
            {
                if (n.Equals("jeden"))
                return tekst[0];
                return tekst[tekst.Length -1];
            }
 
        }


        public Tekst(string txt)
        {
            tekst = new char[txt.Length];
            for     (int i = 0; i < txt.Length; i++)
            {
                tekst[i] = txt[i];
            }
            
        }
    }
}
