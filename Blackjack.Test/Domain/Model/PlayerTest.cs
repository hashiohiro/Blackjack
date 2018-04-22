using Blackjack.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Blackjack.Test.Domain.Model
{
    public class PlayerTest
    {
        [Fact]
        public void Test_First_Draw()
        {
            var stock = new Stock();
            var player = new Player(1, "MurabitoA");

            // ドロー数を手動で書き換える。
            // テストの実行順序により振る舞いが影響を受けるのを防ぐため。
#pragma warning disable CS0612 // 型またはメンバーが古い形式です
            player.SetDrawCount(0);
#pragma warning restore CS0612 // 型またはメンバーが古い形式です

            var cards = player.Draw(stock);
            Assert.Equal(2, cards.Count());
        }

        [Fact]
        public void Test_Draw()
        {
            var stock = new Stock();
            var player = new Player(1, "MurabitoA");

            // ドロー数を手動で書き換える。
            // テストの実行順序により振る舞いが影響を受けるのを防ぐため。
#pragma warning disable CS0612 // 型またはメンバーが古い形式です
            player.SetDrawCount(1);
#pragma warning restore CS0612 // 型またはメンバーが古い形式です

            var cards = player.Draw(stock);
            Assert.Equal(1, cards.Count());
        }
    }
}
