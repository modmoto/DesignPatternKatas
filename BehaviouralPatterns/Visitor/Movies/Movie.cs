using Visitor.Contracts;

namespace Visitor.Movies
{
    public class Movie : IShopItem
    {
        public Movie(string title, int ammountOfOscars, int publishingYear, double prizePerItem)
        {
            Title = title;
            AmmountOfOscars = ammountOfOscars;
            PublishingYear = publishingYear;
            PrizePerItem = prizePerItem;
        }

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