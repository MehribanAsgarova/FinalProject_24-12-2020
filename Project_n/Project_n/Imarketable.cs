using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_n
{
    interface Imarketable
    {
        //Product
        void AddListProduct();
        //Yeni mehsul elave et
        void AddNewListProduct();
        //Mehsul uzerinde duzelis et
        void ChangeProduct();
        //Mehsulu sil
        void DeleteProductListItem();
        //Butun mehsullari goster
        void Products();
        //Categoriyasina gore mehsullari goster
        void ProductKategoriya();
        //Qiymet araligina gore mehsullari goster
        void ProductPriceRange();
        //Mehsullar arasinda ada gore axtaris et
        void ProductName();

        //Sale
        void AddSale();
        //Yeni satis elave etmek
        void AddNewSale();
        //  Satisin silinmesi
        void DeleteSale();
        //Butun satislarin ekrana cixarilmasi
        void Sales();
        //Verilen tarix araligina gore satislarin gosterilmesi
        void DateIntervalSearch();
        //Verilen mebleg araligina gore satislarin gosterilmesi
        void PriceSearch();
        //Verilmis bir tarixde olan satislarin gosterilmesi
        void SearchByDate();
        //Verilmis nomreye esasen hemin nomreli satisin melumatlarinin gosterilmesi
        void SearchBySaleNumber();
        
        
    }
    
}
