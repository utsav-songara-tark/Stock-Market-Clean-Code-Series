using StockMarketCleanCode.DomainModelGenerator;
using StockMarketCleanCode.Executor;
using StockMarketCleanCode.Models;
using StockMarketCleanCode.Repositories;

namespace StockMarketCleanCode.Parser
{
    public class OrderParser
    {
        private readonly UserRepository _userRepository;
        private readonly StockRepository _stockRepository;

        public OrderParser(UserRepository userRepository, StockRepository stockRepository) { 
            _userRepository = userRepository;
            _stockRepository = stockRepository;
        }

        public Order Parser(string orderString)
        {
            string[] inputArray = orderString.Split(" ");

            string userName = inputArray[1];
            string stockCode = inputArray[2];
            string orderType = inputArray[3];
            int price = int.Parse(inputArray[4]);

            User user = _userRepository.AddUser(UserModelGenerator.GenerateUser(userName));
            Stock stock = _stockRepository.AddStock(StockModelGenerator.GenerateStock(stockCode));

            return OrderModelGenerator.GenerateOrder(user, stock, price, orderType);
        }
    }
}
