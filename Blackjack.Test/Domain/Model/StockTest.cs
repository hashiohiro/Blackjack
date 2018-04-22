using Blackjack.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Blackjack.Test.Domain.Model
{
    public class StockTest
    {
        [Fact]
        public void Draw_Test()
        {
            var stock = new Stock();
            var cards = stock.Draw(2);
            Assert.Equal(cards.Count(), 2);
        }

        [Fact]
        public void Shuffle_Test()
        {
            var stock = new Stock();
            stock.Shuffle();
        }
    }
}
