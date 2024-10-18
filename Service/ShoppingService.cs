using ShoppingCart.Controller;
using ShoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Service
{
    public class ShoppingService
    {
        private ShoppingManager _shoppingManager = new ShoppingManager();

        public Customer CreateCustomer()
        {
            // Sample data creation
            var product1 = new Product(1, "Mobile", 2000, 10);
            var product2 = new Product(2, "TV", 1000, 10);

            var lineItem1 = new LineItem(1, 2, product1);
            var lineItem2 = new LineItem(2, 3, product2);

            var order = new Order(1, DateTime.Now, new List<LineItem> { lineItem1, lineItem2 });
            return new Customer(1, "Shubham", new List<Order> { order });
        }

        public double GetTotalOrderPrice(Customer customer)
        {
            return _shoppingManager.CalculateTotalOrderPrice(customer.Orders[0]);
        }

        public double GetLineItemCost(LineItem lineItem)
        {
            return _shoppingManager.CalculateLineItemCost(lineItem);
        }
    }
}