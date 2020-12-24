using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_n
{
    class Marketable : Imarketable
    {
        List<Product> Productlist = new List<Product>();
      
        List<Sale> Salelist = new List<Sale>();

        //Product List
        public void AddListProduct()
        {
            Console.WriteLine("Existing Product List");
            Productlist.Add(new Product() { ProductCode = 10001, ProductName = "Valio", ProductPrice = 2.5, ProductQuantity = 10, kategoriya = (Product.ProductKategoriya.SudMemulatlari) });
            Productlist.Add(new Product() { ProductCode = 10002, ProductName = "Marmelad", ProductPrice = 4.2, ProductQuantity = 9, kategoriya = (Product.ProductKategoriya.Shirniyyat) });
            Productlist.Add(new Product() { ProductCode = 10003, ProductName = "Creker", ProductPrice = 3.1, ProductQuantity = 20, kategoriya = (Product.ProductKategoriya.UnMemulatlari) });
            Console.WriteLine();
            foreach (Product item in Productlist)
            {
                Console.WriteLine(item);
            }
        }


        //Yeni mehsul elave et
        public void AddNewListProduct()
        {
            Console.WriteLine("Enter new Item in  Product List");
            Console.WriteLine("Enter ProductCode");
            int productCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ProductName");
            string productName = (Console.ReadLine());
            Console.WriteLine("Enter ProductPrice");
            double productPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter ProductQuantity");
            int productQuantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Categoriya: 0 - Shirniyyat , 1 - UnMemulatlari,  2 - SudMemulatlari, ");
            int d = (Convert.ToInt32(Console.ReadLine()));

            Productlist.Add(new Product() { ProductCode = productCode, ProductName = productName, ProductPrice = productPrice, ProductQuantity = productQuantity, kategoriya = (Product.ProductKategoriya)d });
            foreach (Product item in Productlist)
            {
                Console.WriteLine(item);

            }
         }

        //Yeni mehsul elave et
        public void ChangeProduct()
        {
            Console.WriteLine("Enter the code of Item you want to Change");
            int productCode = Convert.ToInt32(Console.ReadLine());

            {

                for (int i = 0; i < Productlist.Count; i++)
                {

                    if (Productlist[i].ProductCode == productCode)
                    {
                        Console.WriteLine("Enter Change");
                        Console.WriteLine("Enter ProductName");
                        string productName = (Console.ReadLine());
                        Productlist[i].ProductName = productName;
                        Console.WriteLine("Enter ProductPrice");
                        double productPrice = Convert.ToDouble(Console.ReadLine());
                        Productlist[i].ProductPrice = productPrice;
                        Console.WriteLine("Enter ProductQuantity");
                        int productQuantity = Convert.ToInt32(Console.ReadLine());
                        Productlist[i].ProductQuantity = productQuantity;
                        Console.WriteLine("Enter ProductKategoriya");
                        Console.WriteLine("Enter Product Categoriya: 0 - Shirniyyat , 1 - UnMemulatlari,  2 - SudMemulatlari ");
                        int d = (Convert.ToInt32(Console.ReadLine()));

                        Productlist[i].kategoriya = (Product.ProductKategoriya)d;
                        break;
                    }

                }
            }

            foreach (Product item in Productlist)
            {
                Console.WriteLine(item);

            }

        }
          //Delete item of ArrayList
        public void DeleteProductListItem()
        {
            Console.WriteLine("Enter the code of Item you want to Delete");
            int productCode = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Productlist.Count; i++)

                if (Productlist[i].ProductCode == productCode)
                {
                    Productlist.RemoveAt(i);
                    break;
                }

            foreach (Product item in Productlist)
            {
                Console.WriteLine(item);
            }
        }

        //Last Product List
        public void Products()
        {
            Console.WriteLine("Your last saving Product list is:");
            foreach (Product item in Productlist)
            {
                Console.WriteLine(item);
            }
        }


        //Search by Product Kategoriya
        public void ProductKategoriya()
        {
            Console.WriteLine("Searching by product categoria");
            var a = (Product.ProductKategoriya)0;
            var b = (Product.ProductKategoriya)1;
            var c = (Product.ProductKategoriya)2;

            Console.WriteLine("Enter Product Categoriya: 0 - Shirniyyat , 1 - UnMemulatlari,  2 - SudMemulatlari");
            int d = Convert.ToInt32(Console.ReadLine());


            switch (d)
            {
                case 0:

                    for (int i = 0; i < Productlist.Count; i++)
                    {

                        if (Productlist[i].kategoriya == a)
                        {
                            Console.WriteLine(Productlist[i]);
                        }
                    }
                    break;


                case 1:

                    for (int i = 0; i < Productlist.Count; i++)
                    {
                        if (Productlist[i].kategoriya == b)
                        {
                            Console.WriteLine(Productlist[i]);
                        }
                    }
                    break;
                case 2:

                    for (int i = 0; i < Productlist.Count; i++)
                    {
                        if (Productlist[i].kategoriya == c)
                        {
                            Console.WriteLine(Productlist[i]);
                        }
                    }

                    break;

            }

        }

        //Search by Product Price Range
        public void ProductPriceRange()
        {
                Console.WriteLine("Enter Price Range");
                Console.WriteLine("Enter min Price");
                double min = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter max Price");
                double max = Convert.ToDouble(Console.ReadLine());

                for (int i = 0; i < Productlist.Count; i++)
                {
                    if (Productlist[i].ProductPrice >= min && Productlist[i].ProductPrice <= max)
                    {
                        Console.WriteLine(Productlist[i]);
                    }
                }
        }

        //Search by Product Name
        public void ProductName()
        {
            Console.WriteLine("Enter Product Name");
            string SearchName = Console.ReadLine();
            for (int i = 0; i < Productlist.Count; i++)
            {
                if (Productlist[i].ProductName == SearchName)
                {
                    Console.WriteLine(Productlist[i]);
                }

            }
        }


        //Sale

        //Add Sale
        public void AddSale()
        {

            Salelist.Add(new Sale() { SaleDate = "10.09.2020", SaleNumber = 1, SalePrice = 20.20, });
            Salelist.Add(new Sale() { SaleDate = "11.10.2020", SaleNumber = 3, SalePrice = 50 });
            Salelist.Add(new Sale() { SaleDate = "11.10.2020", SaleNumber = 2, SalePrice = 30.00 });
            foreach (Sale item in Salelist)
            {
                Console.WriteLine(item);

            }
        }

        //Yeni satis elave etmek
        public void AddNewSale()
        {
            Console.WriteLine("Creating new Sale List");
            Console.WriteLine("Enter SaleListNumber");
            int saleNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter SaleListDate, dd.mm.yyyy");
            string saleDate = Console.ReadLine();
            Console.WriteLine("Enter SalePrice");
            double salePrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Sale Items");
            
            Salelist.Add(new Sale() { SaleNumber = saleNumber, SaleDate = saleDate, SalePrice = salePrice });
            foreach (Sale item in Salelist)
            {
                Console.WriteLine(item);
            }
        }

        //Satisin silinmesi
        public void DeleteSale()
        {
            Console.WriteLine("Enter Sale Number you need Delete");
            int searchnumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Salelist.Count; i++)

                if (Salelist[i].SaleNumber == searchnumber)
                {
                    Salelist.RemoveAt(i);
                    break;
                }
            Console.WriteLine("Your new Salelist is:");
            foreach (Sale item in Salelist)
            {
                Console.WriteLine(item);

            }
        }


        //Butun satislarin ekrana cixarilmasi
        public void Sales()
        {
            Console.WriteLine("Your last saving Sale list is:");
            foreach (Sale item in Salelist)
            {
                Console.WriteLine(item);
            }
        }

        
        //Verilen tarix araligina gore satislarin gosterilmesi
        public void DateIntervalSearch()
            {
                Console.WriteLine("Search by Date Interval");
                Console.WriteLine("Enter Min Date , dd.mm.yyyy");
                DateTime mindate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter Max Date , dd.mm.yyyy");
                DateTime maxdate = Convert.ToDateTime(Console.ReadLine());
                foreach (Sale item in Salelist)
                {
                    if (Convert.ToDateTime(item.SaleDate) >= mindate && Convert.ToDateTime(item.SaleDate) <= maxdate)
                    {
                        Console.WriteLine(item);
                    }
                }
            }

        //Verilen mebleg araligina gore satislarin gosterilmesi
        public void PriceSearch()
            {
                Console.WriteLine("Search by Price");
                Console.WriteLine("Enter MinPrice, xx,xx");
                double minprice = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter MaxPrice, xx,xx");
                double maxprice = Convert.ToDouble(Console.ReadLine());
                for (int i = 0; i < Salelist.Count; i++)
                {
                    if (Salelist[i].SalePrice >= minprice && Salelist[i].SalePrice <= maxprice)
                    {
                        Console.WriteLine(Salelist[i]);
                    }
                    
                }
            }

            //Verilmis bir tarixde olan satislarin gosterilmesi 
            public void SearchByDate()
            {
                Console.WriteLine("Search by Date");
                Console.WriteLine("Enter Searching Date, dd.mm.yyyy");
                DateTime searchingdate = Convert.ToDateTime(Console.ReadLine());
                foreach (Sale item in Salelist)
                {
                    if (Convert.ToDateTime(item.SaleDate) == searchingdate)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        //Verilmis nomreye esasen hemin nomreli satisin melumatlarinin gosterilmesi
        public void SearchBySaleNumber()
            {
                Console.WriteLine("Enter Searching Sale Number");
                int searchnumber = Convert.ToInt32(Console.ReadLine());
                foreach (Sale item in Salelist)
                {
                    if (item.SaleNumber == searchnumber)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }

