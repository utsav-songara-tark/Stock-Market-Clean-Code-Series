using StockMarketCleanCode.Models;

namespace StockMarketCleanCode.Repositories
{
    public class UserRepository
    {
        private static List<User> _users = new List<User>();

        public User AddUser(User user)
        {
            var existingUser = GetUser(user.Name);

            if (existingUser != null)
            {
                return existingUser;
            }

            user.Id = $"User-{user.Name}";
            _users.Add(user);
            return user;
        }

        public User GetUser(string name) => _users.Find(u => u.Name == name);

        public void UpdateUserHoldingQuantity(string userId, string stockName, int quantity)
        {
            var user = GetUser(userId);
            var holding = user.Holdings.Find(h => h.StockName == stockName);

            if (holding == null)
            {
                user.Holdings.Add(new Holding
                {
                    StockName = stockName,
                    Quantity = quantity
                });
            }
            else
            {
                holding.Quantity += quantity;
            }
        }
    }
}
