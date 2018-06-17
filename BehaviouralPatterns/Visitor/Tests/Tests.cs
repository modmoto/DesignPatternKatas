using System.Collections.Generic;
using Visitor.Books;
using Visitor.Contracts;
using Visitor.Games;
using Visitor.Movies;
using Visitor.Visitors.Prices;
using Xunit;

namespace Visitor.Tests
{
    public class VisitorTests
    {
        [Fact]
        public void PriceVisitor()
        {
            var game = new Game("Assasins Crees", "Ubisoft", 1, 1, 59);
            var book = new Book("Hunger Games", "Alan", 2008, 29);
            var movie = new Movie("Star Wars", 3, 1988, 4);
            var checkoutCart = new CheckoutCart();
            var calculatedSum = checkoutCart.CalculateSum(new PriceVisitor(), new List<IShopItem> {game, movie, book});
            Assert.Equal(92, calculatedSum);
        }

        [Fact]
        public void TwentyPercentOffPriceVisitor()
        {
            var game = new Game("Assasins Crees", "Ubisoft", 1, 1, 59);
            var book = new Book("Hunger Games", "Alan", 2008, 29);
            var movie = new Movie("Star Wars", 3, 1988, 4);
            var checkoutCart = new CheckoutCart();
            var calculatedSum = checkoutCart.CalculateSum(new TwentyPercentOffPriceVisitor(), new List<IShopItem> {game, movie, book});
            Assert.Equal(79.4, calculatedSum);
        }

        [Fact]
        public void BuyTwoGetOneFreeVisitor_OneOnly()
        {
            var game = new Game("Assasins Crees", "Ubisoft", 1, 1, 59);
            var book = new Book("Hunger Games", "Alan", 2008, 29);
            var movie = new Movie("Star Wars", 3, 1988, 4);
            var checkoutCart = new CheckoutCart();
            var calculatedSum = checkoutCart.CalculateSum(new BuyTwoGetOneFreeVisitor(), new List<IShopItem> {game, movie, book});
            Assert.Equal(92, calculatedSum);
        }

        [Fact]
        public void BuyTwoGetOneFreeVisitor_3Games()
        {
            var game = new Game("Assasins Crees", "Ubisoft", 1, 1, 59);
            var game2 = new Game("Assasins Crees", "Ubisoft", 1, 1, 59);
            var game3 = new Game("Assasins Crees", "Ubisoft", 1, 1, 59);
            var checkoutCart = new CheckoutCart();
            var calculatedSum = checkoutCart.CalculateSum(new BuyTwoGetOneFreeVisitor(), new List<IShopItem> {game, game2, game3});
            Assert.Equal(118, calculatedSum);
        }

        [Fact]
        public void BuyTwoGetOneFreeVisitor_3Movies_NoChange()
        {
            var movie = new Movie("Star Wars", 3, 1988, 4);
            var movie2 = new Movie("Star Wars", 3, 1988, 4);
            var movie3 = new Movie("Star Wars", 3, 1988, 4);
            var checkoutCart = new CheckoutCart();
            var calculatedSum = checkoutCart.CalculateSum(new BuyTwoGetOneFreeVisitor(), new List<IShopItem> {movie2, movie3, movie});
            Assert.Equal(12, calculatedSum);
        }
    }
}