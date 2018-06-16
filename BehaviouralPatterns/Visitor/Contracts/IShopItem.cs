namespace Visitor.Contracts
{
    public interface IShopItem
    {
        void Visit(IShopItemVisitor shopItemVisitor);
    }
}