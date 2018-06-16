using Visitor.Contracts;

namespace Visitor.Visitors.Prices
{
    public interface IPriceVisitor : IShopItemVisitor
    {
        double Sum { get; }
    }
}