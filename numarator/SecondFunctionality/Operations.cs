using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numarator.SecondFunctionality
{
    enum variables
    {
        ucun_kati,
        besin_kati,
        hem_3_hem_5_in_kati,
    }
    class Operations
    {
        public string Control(int item)
        {
            if(item % 15 == 0 && item < 100)
            {
                return "zigzag";
            }
            if (item % 15 == 0 && item > 100)
            {
                return "zagzig";
            }
            else if(item % 3 == 0)
            {
                return "zig";
            }
            else if(item % 5 == 0)
            {
                return "zag";
            }
            else
            {
                return item.ToString();
            }


        }
    }
}
