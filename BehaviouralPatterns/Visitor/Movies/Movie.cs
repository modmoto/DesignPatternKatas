using Visitor.Contracts;

namespace Visitor.Movies
{
    public class Movie : IShopItem
    {
        public string Title { get; }
        public int AmmountOfOscars{ get; }
        public int PublishingYear { get; }
        public double PrizePerItem { get; }

        public void Visit(IShopItemVisitor shopItemVisitor)
        {
            shopItemVisitor.Visit(this);
        }
    }
}