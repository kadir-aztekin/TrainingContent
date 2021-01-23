using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;


            Product product2 = new Product { ID = 2, CategoryId = 5, UnitInStock = 5, ProductName = "Kalem", UnitPrice = 35};
            //PASCALCASE   //camelCASE   (CASESENSİTİVE BUYUK KUCUK DUYARLILIGI VARDIR ) 
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);   
            
            

            
        }
    }
}
