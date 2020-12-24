using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_n
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Product  --  1");
            Console.WriteLine("Sale  --  2");
            Console.WriteLine("Exit -- 3");

            Marketable marketable = new Marketable();

            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                //Product
                marketable.AddListProduct();
                //1 Yeni mehsul elave et
                marketable.AddNewListProduct();
                //2 Mehsul uzerinde duzelis et
                marketable.ChangeProduct();
                //3 Mehsulu sil
                marketable.DeleteProductListItem();
                //4 Butun mehsullari goster
                marketable.Products();
                //5 Categoriyasina gore mehsullari goster
                marketable.ProductKategoriya();
                //6 Qiymet araligina gore mehsullari goster
                marketable.ProductPriceRange();
                //7 Mehsullar arasinda ada gore axtaris et
                marketable.ProductName();
            }

            else if (n == 2)
            {
                //Sale
                marketable.AddSale();
                //Yeni satis elave etmek
                marketable.AddNewSale();
                //Satisin silinmesi
                marketable.DeleteSale();
                //Butun satislarin ekrana cixarilmasi
                marketable.Sales();
                //Verilen tarix araligina gore satislarin gosterilmesi
                marketable.DateIntervalSearch();
                //Verilen mebleg araligina gore satislarin gosterilmesi
                marketable.PriceSearch();
                //Verilmis bir tarixde olan satislarin gosterilmesi 
                marketable.SearchByDate();
                //Verilmis nomreye esasen hemin nomreli satisin melumatlarinin gosterilmesi
                marketable.SearchBySaleNumber();
            }

            else if (n == 3)
            {
                Console.WriteLine("Exit");
            }


        }
    }
}
