using ShoppingCart.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Presentation.cs
{
    public class ShoppingPresentation
    {
        //private ShoppingService _shoppingService = new ShoppingService();
        
        public static void ShowCustomerDetails()
        {
            var Services = new ShoppingService();
            var customer = Services.CreateCustomer();
            var order = customer.Orders[0];
            Console.WriteLine($"Customer ID : {customer.Id}\nCustomer Name : {customer.Name}\nOrder Date : {order.Date}\n");

            foreach (var lineItem in order.Items)
            {
                var unitPrice = lineItem.Product.Price;
                var discount = lineItem.Product.DiscountPercent;
                var unitCostAfterDiscount = unitPrice * (1 - (discount / 100));
                var totalLineItemCost = Services.GetLineItemCost(lineItem);

                Console.WriteLine($"LineItem ID: {lineItem.Id} | " +
                                  $"Product ID: {lineItem.Product.Id} | " +
                                  $"Product Name: {lineItem.Product.Name} | " +
                                  $"Quantity : {lineItem.Quantity} | " +
                                  $"Unit Price : {unitPrice} | " +
                                  $"Discount : {discount}% | " +
                                  $"Unit Cost After Discount : {unitCostAfterDiscount} | " +
                                  $"Total LineItem Cost: {totalLineItemCost} | \n");
            }
            Console.WriteLine($"Total Order Price : {Services.GetTotalOrderPrice(customer)}");
        }
    }

}