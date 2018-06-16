using Visitor.Contracts;

namespace Visitor.Games
{
    public class Game : IShopItem
    {
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