using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_14_Wpf
{
    public enum ProductTypes
    {
        Food,
        Technic
    }

    public class Product
    {
        public string ProductName { get; set; } // название продукта
        public int Price { get; set; } // цента товара 
        public string ImageName { get; set; }         // число определ. приоритет 
        public ProductTypes ProductType { get; set; } // тип продуктов (вынесен выше и доступен всем) 


        public override string ToString()
        {
            return ProductName; // возвращаем название продукта
        }
    }
}
