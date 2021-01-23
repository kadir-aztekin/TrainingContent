using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //ENTİTY (VARLIKLAR) 
    {
        public int ID { get; set; }
        public int CategoryId { get; set; }

        public string ProductName { get; set; } //ÜRÜN İSMİ
        public double UnitPrice { get; set; } //FİYATI DEMEK
        public int UnitInStock { get; set; } //STOK ADEDİ
    }
}
