using StockMarketCleanCode.Models;

namespace StockMarketCleanCode.Repositories
{
    public class StockRepository
    {
        private static List<Stock> _stocks = new();

        public Stock AddStock(Stock addStock)
        {
            var stock = _stocks.Find(s => s.Code == addStock.Code);

            if (stock is null)
            {
                _stocks.Add(stock);
            }
            return stock;
        }

        public Stock GetStock(string name) => _stocks.Find(s => s.Code == name);
    }
}
