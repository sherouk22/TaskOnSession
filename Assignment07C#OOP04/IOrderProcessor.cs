using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment07C_OOP04
{
    public  interface IOrderProcessor
    {
        public void ProcessOrder();

        decimal CalculateDiscount(decimal orderAmount);

   

    }

    public class OnlineOrderProcessor : IOrderProcessor
    {
        public void ProcessOrder()
        {
            Console.WriteLine("Processing online order.");
        }

        public decimal CalculateDiscount(decimal orderAmount)
        {
            return orderAmount * 0.10m; 
        }

        

    }

    public class InStoreOrderProcessor : IOrderProcessor
    {

        public void ProcessOrder()
        {
            Console.WriteLine("Processing in store order.");
        }

        public decimal CalculateDiscount(decimal orderAmount)
        {
            return orderAmount * 0.05m;
        }





    }


    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public decimal OrderAmount { get; set; }
        public IOrderProcessor OrderProcessor { get; set; }




        public void Process()
        {
            OrderProcessor.ProcessOrder();
            decimal discount = OrderProcessor.CalculateDiscount(OrderAmount);
            decimal finalAmount = OrderAmount - discount;
            Console.WriteLine($"Order {OrderId} processed for {CustomerName}. Final amount after {discount:P0} discount: ${finalAmount:F2}");
        }


    }

}
