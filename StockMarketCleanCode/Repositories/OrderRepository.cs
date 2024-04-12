using StockMarketCleanCode.Models;

namespace StockMarketCleanCode.Repositories
{
    public class OrderRepository
    {
        private static List<Order> _orders = new();
        private static int _orderId = 1;

        public void AddOrder(Order order)
        {
            order.Id = $"Order-{_orderId++}";
            _orders.Add(order);
            log(order);
        }

        public List<Order> GetOrdersToTrade(Order order) => _orders.Where(o => o.Stock.Code == order.Stock.Code && !order.IsTraded && order.Type != o.Type).ToList();

        private static void log(Order order)
        {
            Console.WriteLine($"Order: {order.Type} {order.User.Name} {order.Stock.Code} {order.Type} {order.Price}");
        }
    }
}
