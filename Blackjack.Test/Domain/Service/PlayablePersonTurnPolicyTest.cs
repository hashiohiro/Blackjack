using Blackjack.Domain.Enum;
using Blackjack.Domain.Model;
using Blackjack.Domain.Service.Policy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Blackjack.Test.Domain.Service
{
    public class PlayablePersonTurnPolicyTest
    {
        [Fact]
        public void Test_Process()
        {
            var stock = new Stock();
            var dealer = new Dealer(1, "Dealer");
            var policy = new DealerTurnPolicy();

            policy.Process(stock, dealer);

            Assert.True(dealer.TotalValue > 17);
        }

        [Fact]
        public void Test_NeedDraw()
        {
            var policy = new DealerTurnPolicy();
            var dealer = new Dealer(1, "Dealer");

            // 手札のカードを手動で設定する。
            // テストがランダム処理の影響を受けるのを防ぐため。
#pragma warning disable CS0612 // 型またはメンバーが古い形式です
            dealer.AddCard(new Card(Suit.Club, CardNumber.Ace));
#pragma warning restore CS0612 // 型またはメンバーが古い形式です

            Assert.True(policy.NeedDraw(dealer));
        }

        [Fact]
        public void Test_NoNeedDraw()
        {
            var policy = new DealerTurnPolicy();
            var dealer = new Dealer(1, "Dealer");

            // 手札のカードを手動で設定する。
            // テストがランダム処理の影響を受けるのを防ぐため。
#pragma warning disable CS0612 // 型またはメンバーが古い形式です
            dealer.AddCard(new Card(Suit.Club, CardNumber.Ace));
            dealer.AddCard(new Card(Suit.Club, CardNumber.Six));
            dealer.AddCard(new Card(Suit.Club, CardNumber.Ten));
#pragma warning restore CS0612 // 型またはメンバーが古い形式です

            Assert.False(policy.NeedDraw(dealer));
        }
    }
}
