using Blackjack.Domain.Enum;
using Blackjack.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Blackjack.Test.Domain.Model
{
    public class DealerTest
    {
        [Fact]
        public void Test_First_Draw()
        {
            var stock = new Stock();
            var dealer = new Dealer(1, "MurabitoA");

            // ドロー数を手動で書き換える。
            // テストの実行順序により振る舞いが影響を受けるのを防ぐため。
#pragma warning disable CS0612 // 型またはメンバーが古い形式です
            dealer.SetDrawCount(0);
#pragma warning restore CS0612 // 型またはメンバーが古い形式です
            var cards = dealer.Draw(stock);
            Assert.Equal(cards.Count(), 2);
        }

        [Fact]
        public void Test_Draw()
        {
            var stock = new Stock();
            var dealer = new Dealer(1, "MurabitoA");

            // ドロー数を手動で書き換える。
            // テストの実行順序により振る舞いが影響を受けるのを防ぐため。
#pragma warning disable CS0612 // 型またはメンバーが古い形式です
            dealer.SetDrawCount(1);
#pragma warning restore CS0612 // 型またはメンバーが古い形式です

            var cards = dealer.Draw(stock);
            Assert.Equal(cards.Count(), 1);
        }

        [Fact]
        public void Test_TotalValue()
        {
            var dealer = new Dealer(1, "MurabitoA");

            // 手札のカードを手動で設定する。
            // テストがランダム処理の影響を受けるのを防ぐため。
#pragma warning disable CS0612 // 型またはメンバーが古い形式です
            dealer.AddCard(new Card(Suit.Club, CardNumber.Ace));
            dealer.AddCard(new Card(Suit.Diamond, CardNumber.King));
            dealer.AddCard(new Card(Suit.Heart, CardNumber.Queen));
#pragma warning restore CS0612 // 型またはメンバーが古い形式です

            Assert.Equal(21, dealer.TotalValue);
        }

        [Fact]
        public void Test_NeedDraw()
        {
            var dealer = new Dealer(1, "MurabitoA");

            // 手札のカードを手動で設定する。
            // テストがランダム処理の影響を受けるのを防ぐため。
#pragma warning disable CS0612 // 型またはメンバーが古い形式です
            dealer.AddCard(new Card(Suit.Diamond, CardNumber.King));
#pragma warning restore CS0612 // 型またはメンバーが古い形式です
            Assert.Equal(true, dealer.NeedDraw);
        }

        [Fact]
        public void Test_DoNotNeedDraw()
        {
            var dealer = new Dealer(1, "MurabitoA");

            // 手札のカードを手動で設定する。
            // テストがランダム処理の影響を受けるのを防ぐため。
#pragma warning disable CS0612 // 型またはメンバーが古い形式です
            dealer.AddCard(new Card(Suit.Diamond, CardNumber.King));
            dealer.AddCard(new Card(Suit.Diamond, CardNumber.King));
#pragma warning restore CS0612 // 型またはメンバーが古い形式です
            Assert.Equal(false, dealer.NeedDraw);
        }
    }
}
