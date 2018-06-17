using Visitor.Contracts;

namespace Visitor.Games
{
    public class Game : IShopItem
    {
        public Game(string title, string publisherName, int ammountOfMinimumPlayers, int ammountOfMaximumPlayers, double prizePerItem)
        {
            Title = title;
            PublisherName = publisherName;
            AmmountOfMinimumPlayers = ammountOfMinimumPlayers;
            AmmountOfMaximumPlayers = ammountOfMaximumPlayers;
            PrizePerItem = prizePerItem;
        }

        public string Title { get; }
        public string PublisherName{ get; }
        public int AmmountOfMinimumPlayers { get; }
        public int AmmountOfMaximumPlayers { get; }
        public double PrizePerItem { get; }

        public void Visit(IShopItemVisitor shopItemVisitor)
        {
            shopItemVisitor.Visit(this);
        }
    }
}