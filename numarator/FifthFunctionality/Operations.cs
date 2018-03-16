using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numarator.FifthFunctionality
{
    class Operations
    {
        public int GetNthFibonacci_Rec(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;

            }
            else
                return GetNthFibonacci_Rec(n - 1) + GetNthFibonacci_Rec(n - 2);
        }
    }
}
