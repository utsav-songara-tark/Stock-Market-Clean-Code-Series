namespace StockMarketCleanCode.Models
{
    public abstract class Order(User user, Stock stock, double price)
    {
        public string Id { get; set; }
        public User User { get; set; } = user;
        public Stock Stock { get; set; } = stock;
        public double Price { get; set; } = price;
        public abstract string Type { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public bool IsTraded { get; set; } = false;
        public int Quantity { get; set; } = 1;

        public void ChangeOrderToTraded()
        {
            IsTraded = true;
        }
    }
}
