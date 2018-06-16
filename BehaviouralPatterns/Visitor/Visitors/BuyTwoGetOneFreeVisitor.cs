
using Visitor.Books;
using Visitor.Contracts;
using Visitor.Games;
using Visitor.Movies;

namespace Visitor.Visitors
{
    public class BuyTwoGetOneFreeVisitor : IShopItemVisitor
    {
        public double Sum { get; private set; }
        public int AmmountBooks { get; private set; }
        public int AmmountMovies { get; private set; }

        public void Visit(Book book)
        {
            AmmountBooks++;
            if (AmmountBooks != 3) Sum += book.PrizePerItem;
        }

        public void Visit(Movie movie)
        {
            AmmountMovies++;
            if (AmmountMovies != 3) Sum += movie.PrizePerItem;
        }

        public void Visit(Game game)
        {
            Sum += game.PrizePerItem;
        }
    }
}