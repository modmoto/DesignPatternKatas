using Visitor.Books;
using Visitor.Games;
using Visitor.Movies;

namespace Visitor.Visitors.Prices
{
    public class PriceVisitor : IPriceVisitor
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