using StockMarketCleanCode.Models;

namespace StockMarketCleanCode.DomainModelGenerator
{
    public class OrderModelGenerator
    {
        public static Order GenerateOrder(User user, Stock stock, double orderPrice, string type)
        {
            if (type == "BID")
            {
                return new BidOrder(user, stock, orderPrice);
            }
            else if (type == "OFFER")
            {
                return new OfferOrder(user, stock, orderPrice);
            }
            else
            {
                throw new Exception("Invalid order type");
            }
        }
    }
}
