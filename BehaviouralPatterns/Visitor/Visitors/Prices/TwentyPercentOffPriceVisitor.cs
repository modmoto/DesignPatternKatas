using Visitor.Books;
using Visitor.Games;
using Visitor.Movies;

namespace Visitor.Visitors.Prices
{
    public class TwentyPercentOffPriceVisitor : IPriceVisitor
    {
        public double Sum { get; private set; }

        public void Visit(Book book)
        {
            Sum += book.PrizePerItem;
        }

        public void Visit(Movie movie)
        {
            Sum += movie.PrizePerItem * 0.8;
        }

        public void Visit(Game game)
        {
            Sum += game.PrizePerItem * 0.8;
        }
    }
}