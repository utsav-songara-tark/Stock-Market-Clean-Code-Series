namespace StockMarketCleanCode.Models
{
    public class BidOrder(User user, Stock stock, double orderPrice) : Order(user, stock, orderPrice)
    {
        public override string Type { get; set; } = "BID";
    }
}
