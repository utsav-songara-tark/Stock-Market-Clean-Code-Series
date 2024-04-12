using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarketCleanCode.Executor;
using StockMarketCleanCode.Models;
using StockMarketCleanCode.Parser;
using StockMarketCleanCode.Repositories;

namespace StockMarketCleanCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderParser _orderParser;
        private readonly TradeEngine _tradeEngine;
        private readonly OrderRepository _orderRepository;

        public OrderController(OrderParser orderParser, TradeEngine tradeExecutor, OrderRepository orderRepository)
        {
            _orderParser = orderParser;
            _tradeEngine = tradeExecutor;
            _orderRepository = orderRepository;
        }

        [HttpPost]
        public IActionResult PlaceOrder(string orderRequestString)
        {
            Order order = _orderParser.Parser(orderRequestString);
            _tradeEngine.PlaceOrder(order);
            _orderRepository.AddOrder(order);
            return Ok();
        }
    }
}
