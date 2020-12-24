using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_n
{
    class SaleItem
    {
        public readonly int ItemNumber = 101;
        public readonly int ItemCount=2;
        public readonly string ItemName="Mars";

        public readonly int ItemNumber1 = 102;
        public readonly int ItemCount1 = 3;
        public readonly string ItemName1 = "Twix";

        public readonly int ItemNumber2 = 103;
        public readonly int ItemCount2 = 1;
        public readonly string ItemName2 = "Mars";

        public SaleItem()
        {

        }

        public override string ToString()
        {
            return ItemNumber + ItemName + ItemCount + ItemNumber1 + ItemName1 + ItemCount1 + ItemNumber2 + ItemName2 + ItemCount2;
        }


    }
}

