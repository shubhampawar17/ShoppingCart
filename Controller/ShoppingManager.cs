using ShoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Controller
{
    public class ShoppingManager
    {
        public double CalculateTotalOrderPrice(Order order)
        {
            return order.CalculateOrderPrice();
        }

        public double CalculateLineItemCost(LineItem lineItem)
        {
            return lineItem.CalculateLineItemCost();
        }
    }
}
