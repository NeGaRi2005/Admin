using A.Domian.ProductCategorys;
using System;

namespace A.Domian.Products
{
    public class Product
    {
        public Product(string name, double price, int discount, DateTime time, bool isStock, long idCategory)
        {
            Name = name;
            Price = price;
            Discount = discount;
            Time = time;
            IsStock = isStock;
            IdCategory = idCategory;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
         public int Discount { get; set; }
        public DateTime Time { get; set; }
        public bool IsStock { get; set; }
        public long IdCategory { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
}
