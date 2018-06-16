using System.Collections.Generic;
using Visitor.Contracts;
using Visitor.Visitors;
using Visitor.Visitors.Prices;

namespace Visitor
{
    public class CheckoutCart
    {
        public double CalculateSum(IPriceVisitor priceVisitor, IEnumerable<IShopItem> shopItems)
        {
            foreach (var shopItem in shopItems)
            {
                shopItem.Visit(priceVisitor);
            }

            return priceVisitor.Sum;
        }
    }
}