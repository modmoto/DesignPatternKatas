using Visitor.Contracts;

namespace Visitor.Books
{
    public class Book : IShopItem
    {
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