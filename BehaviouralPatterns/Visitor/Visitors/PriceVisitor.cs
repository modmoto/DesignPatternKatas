using Visitor.Books;
using Visitor.Contracts;
using Visitor.Games;
using Visitor.Movies;

namespace Visitor.Visitors
{
    public class PriceVisitor : IShopItemVisitor
    {
        public double Sum { get; private set; }

        public void Visit(Book book)
        {
            Sum += book.PrizePerItem;
        }

        public void Visit(Movie movie)
        {
            Sum += movie.PrizePerItem;
        }

        public void Visit(Game game)
        {
            Sum += game.PrizePerItem;
        }
    }
}