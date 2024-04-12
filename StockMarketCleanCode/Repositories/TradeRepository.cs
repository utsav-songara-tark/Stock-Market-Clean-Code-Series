using StockMarketCleanCode.Models;

namespace StockMarketCleanCode.Repositories
{
    public class TradeRepository
    {
        private static List<Trade> _trades = new();
        private static int _tradeId = 1;

        public static void AddTrade(Trade trade)
        {
            trade.Id = $"Trade-{_tradeId++}";
            _trades.Add(trade);
        }
    }
}
