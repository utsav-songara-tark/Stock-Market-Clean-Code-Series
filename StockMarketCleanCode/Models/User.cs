namespace StockMarketCleanCode.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Holding> Holdings { get; set; } = new List<Holding>();
    }
}
