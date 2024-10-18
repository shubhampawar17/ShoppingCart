using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountPercent {  get; set; }
        int Divider = 100;

        public Product(int id , string name , double price , double discountPercent)
        {
            Id = id;
            Name = name;
            Price = price;
            DiscountPercent = discountPercent;
        }
        public double CalculateDiscountPrice()
        {
            return Price - (Price * DiscountPercent/Divider);
        }
    }
}