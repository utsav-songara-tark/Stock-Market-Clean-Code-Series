namespace StockMarketCleanCode.Models
{
    public class OfferOrder(User user, Stock stock, double offerPrice) : Order(user, stock, offerPrice)
    {
        public override string Type { get; set; } = "OFFER";
    }
}
