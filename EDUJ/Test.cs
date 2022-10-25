using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUJ
{
    public class Test
    {

        public const int varConst = 1;
        public readonly int varReadonly = 1;

        public Test(int n)
        {
            // varConst = n; <- to jest const ! nie możemy zmienić mu wartości
            varReadonly = n; // readonly można zmieniać TYLKO w konstruktorze!
        }
        void Change()
        {
            // varConst = 2; const jest stałe!
            // varReadonly = 2; tylko do odczytu !
        }
    }
}
