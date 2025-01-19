namespace Assignment07C_OOP04
{
    internal class Program
    {

       

        static void Main(string[] args)
        {

            Console.WriteLine("Enter Order ID:");
            int orderId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Customer Name:");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter Order Amount:");
            decimal orderAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Order Type (Online/In-Store):");
            string orderType = Console.ReadLine();

            Order order = new Order
            {
                OrderId = orderId,
                CustomerName = customerName,
                OrderAmount = orderAmount,
                OrderProcessor = GetOrderProcessor(orderType)
            };

            order.Process();

            Console.ReadLine();

            static IOrderProcessor GetOrderProcessor(string orderType)
            {
                switch (orderType.ToLower())
                {
                    case "online":
                        return new OnlineOrderProcessor();
                    case "in-store":
                        return new InStoreOrderProcessor();
                    default:
                        throw new ArgumentException("Invalid order type.");
                }
            }
        }
    }
}
