namespace StockMarketCleanCode.Models
{
    public class OrderInputRequest
    {
        public string UserName { get; set; }
        public string StockName { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
    }
}
