using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_n
{
    class Product
    {

        SaleItem SaleItem = new SaleItem();
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public enum ProductKategoriya
        {

            Shirniyyat,
            UnMemulatlari,
            SudMemulatlari,
        }
        public ProductKategoriya kategoriya { get; set; }

        public int ProductQuantity { get; set; }

        public int ProductCode { get; set; }

       
        public Product()
        {
          
        }

        public override string ToString()
        {
            return "ProductKategoriya  " + kategoriya + "   ProductCode: " + ProductCode + "   ProductName: " + ProductName + "   ProductPrice: " + ProductPrice + "   ProductQuantity: " + ProductQuantity;
        }
       
    }
    
    }

    
