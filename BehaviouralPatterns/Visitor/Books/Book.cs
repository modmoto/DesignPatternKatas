using Visitor.Contracts;

namespace Visitor.Books
{
    public class Book : IShopItem
    {
        public Book(string title, string authorname, int publishingYear, double prizePerItem)
        {
            Title = title;
            Authorname = authorname;
            PublishingYear = publishingYear;
            PrizePerItem = prizePerItem;
        }

        public string Title { get; }
        public string Authorname { get; }
        public int PublishingYear { get; }
        public double PrizePerItem { get; }

        public void Visit(IShopItemVisitor shopItemVisitor)
        {
            shopItemVisitor.Visit(this);
        }
    }
}