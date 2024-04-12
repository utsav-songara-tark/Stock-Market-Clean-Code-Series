using StockMarketCleanCode.Models;

namespace StockMarketCleanCode.DomainModelGenerator
{
    public class UserModelGenerator
    {
        public static User GenerateUser(string name)
        {
            return new User
            {
                Name = name
            };
        }
    }
}
