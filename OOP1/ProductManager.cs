using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) //PRODUCT SINIFINDAN VERI AL DEMEK İNT ID , İNT PRODUCT NAME YAZMAK YERINE CLASSI YAZDIK 
        {
            Console.WriteLine(product.ProductName+" "+"Eklendi");
        }
        public void Update(Product product) //GUNCELLEME
        {
            Console.WriteLine(product.ProductName + " " + "Guncellendi");
        }
        public void Delete(Product product )
        {
            Console.WriteLine(product.ProductName + " " + "Silindi");
        }
        
        

    }
}
