using StockMarketCleanCode.Models;

namespace StockMarketCleanCode.DomainModelGenerator
{
    public class StockModelGenerator
    {
        public static Stock GenerateStock(string name)
        {
            return new Stock
            {
                Code = name
            };
        }
    }
}
