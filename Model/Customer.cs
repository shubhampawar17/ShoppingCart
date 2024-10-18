using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(int id, string name, List<Order> orders)
        {
            Id = id;
            Name = name;
            Orders = orders;
        }
        public double CalculateTotalSpent()
        {
            double total = 0;
            foreach (var order in Orders)
            {
                total = total + order.CalculateOrderPrice();
            }
            return total;
        }
    }
}