using Visitor.Books;
using Visitor.Games;
using Visitor.Movies;

namespace Visitor.Contracts
{
    public interface IShopItemVisitor
    {
        void Visit(Book book);
        void Visit(Movie movie);
        void Visit(Game game);
    }
}