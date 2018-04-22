using Blackjack.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Blackjack.Test.Domain.Model
{
    public class PlayablePersonTest
    {

        [Fact]
        public void Test_IsFirstDraw()
        {
            var stock = new Stock();
            var player = new Player(1, "MurabitoA");

            Assert.Equal(true, player.IsFirstDraw);
        }

        [Fact]
        public void Test_IsNotFirstDraw()
        {
            var stock = new Stock();
            var player = new Player(1, "MurabitoA");
            player.Draw(stock);

            Assert.Equal(false, player.IsFirstDraw);
        }

        [Fact]
        public void Test_DrawCount()
        {
            var stock = new Stock();
            var player = new Player(1, "MurabitoA");
            player.Draw(stock);
            player.Draw(stock);

            Assert.Equal(3, player.DrawCount);
        }
    }
}
