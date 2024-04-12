using StockMarketCleanCode.Models;
using StockMarketCleanCode.Repositories;

namespace StockMarketCleanCode.Executor
{
    public class TradeEngine
    {
        private OrderRepository _orderRepository;
        public TradeRepository _tradeRepository;

        public TradeEngine(OrderRepository orderRepository, TradeRepository tradeRepository)
        {
            _orderRepository = orderRepository;
            _tradeRepository = tradeRepository;
        }

        public void PlaceOrder(Order order)
        {
            if (order is BidOrder bidOrder)
            {
                TradeWithBidOrder(bidOrder);
            }
            else if (order is OfferOrder offerOrder)
            {
                TradeWithOfferOrder(offerOrder);
            }
        }

        private void TradeWithBidOrder(BidOrder bidOrder)
        {
            var ordersToTrade = _orderRepository.GetOrdersToTrade(bidOrder);
            foreach (var order in ordersToTrade)
            {
                if (bidOrder.Price >= order.Price)
                {
                    Trade trade = new Trade(bidOrder, order, order.Price);
                    _tradeRepository.AddTrade(trade);
                    bidOrder.IsTraded = true;
                    order.IsTraded = true;
                }
            }
        }
    }
}
