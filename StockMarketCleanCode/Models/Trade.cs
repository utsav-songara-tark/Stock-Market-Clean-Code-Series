namespace StockMarketCleanCode.Models
{
    public class Trade
    {
        public string Id { get; set; }
        public BidOrder BidOrder { get; set; }
        public OfferOrder OfferOrder { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
