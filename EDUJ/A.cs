using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUJ
{


    class A
    {
        // int defaultVar; == private 

        private int privateVar;
        protected int protectedVar;
        internal int internalVar;
        public int publiclVar;

        protected internal int protectedInternalVar;
        private protected int privateProtectedVar;




    }

    class B : A
    {
        void Test()
        {

        }
    }
}

 