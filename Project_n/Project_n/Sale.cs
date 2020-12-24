using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_n
{ 
    class Sale
    {
        SaleItem SaleItem = new SaleItem();
        
        public int SaleNumber { get; set; }

        public double SalePrice { get; set; }

        public string SaleDate { get; set; }

        
        public Sale()
        {

        }

               public override string ToString()
        {
            return "SaleDate:  " + SaleDate + "  SaleNumber   " + SaleNumber + "  SalePrice:  " + SalePrice + "    " + SaleItem.ItemNumber + "    " + SaleItem.ItemName + "    " + SaleItem.ItemCount + "    " + SaleItem.ItemNumber1 + SaleItem.ItemName1 + "    " + SaleItem.ItemCount1 + "    " + SaleItem.ItemNumber2 + "    " + SaleItem.ItemName2 + "    " + SaleItem.ItemCount2;
        }
    }
       
    
}
