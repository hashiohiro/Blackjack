using Blackjack.Domain.Enum;
using Blackjack.Domain.Model;
using Blackjack.Domain.Service;
using Blackjack.Domain.Service.Policy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Blackjack.Test.Domain.Service
{
    public class JudgementPolicyTest
    {
        [Fact]
        public void Test_Judgement_WinPlayer()
        {
            var judgement = new JudgementPolicy();

#pragma warning disable CS0612 // 型またはメンバーが古い形式です
            var player = new Player(1, "Winner Player");
            player.AddCard(new Card(Suit.Club, CardNumber.Ace));
            player.AddCard(new Card(Suit.Club, CardNumber.Eight));
            player.AddCard(new Card(Suit.Club, CardNumber.Two));
#pragma warning restore CS0612 // 型またはメンバーが古い形式です

#pragma warning disable CS0612 // 型またはメンバーが古い形式です
            var dealer = new Dealer(1, "Loser Dealer");
            dealer.AddCard(new Card(Suit.Club, CardNumber.Four));
            dealer.AddCard(new Card(Suit.Club, CardNumber.Six));
            dealer.AddCard(new Card(Suit.Club, CardNumber.Jack));
#pragma warning restore CS0612 // 型またはメンバーが古い形式です

            var winner = judgement.Judge(dealer, player);

            Assert.Equal(winner, player);
        }

        [Fact]
        public void Test_Judgement_LosePlayer()
        {
            var judgement = new JudgementPolicy();

#pragma warning disable CS0612 // 型またはメンバーが古い形式です
            var player = new Dealer(1, "Loser Player");
            player.AddCard(new Card(Suit.Club, CardNumber.Four));
            player.AddCard(new Card(Suit.Club, CardNumber.Six));
            player.AddCard(new Card(Suit.Club, CardNumber.Jack));
#pragma warning restore CS0612 // 型またはメンバーが古い形式です

#pragma warning disable CS0612 // 型またはメンバーが古い形式です
            var dealer = new Player(1, "Winner Dealer");
            dealer.AddCard(new Card(Suit.Club, CardNumber.Ace));
            dealer.AddCard(new Card(Suit.Club, CardNumber.Eight));
            dealer.AddCard(new Card(Suit.Club, CardNumber.Two));
            
#pragma warning restore CS0612 // 型またはメンバーが古い形式です

            var winner = judgement.Judge(player, dealer);

            Assert.Equal(winner, dealer);
        }

        [Fact]
        public void Test_Judgement_NoWinner()
        {
            var judgement = new JudgementPolicy();

#pragma warning disable CS0612 // 型またはメンバーが古い形式です
            var player = new Player(1, "Winner Player");
            player.AddCard(new Card(Suit.Club, CardNumber.Ace));
            player.AddCard(new Card(Suit.Club, CardNumber.Four));
            player.AddCard(new Card(Suit.Club, CardNumber.Jack));
#pragma warning restore CS0612 // 型またはメンバーが古い形式です

#pragma warning disable CS0612 // 型またはメンバーが古い形式です
            var dealer = new Dealer(1, "Loser Dealer");
            dealer.AddCard(new Card(Suit.Club, CardNumber.Ace));
            dealer.AddCard(new Card(Suit.Club, CardNumber.Four));
            dealer.AddCard(new Card(Suit.Club, CardNumber.Jack));
            
#pragma warning restore CS0612 // 型またはメンバーが古い形式です

            var winner = judgement.Judge(dealer, player);

            Assert.Equal(winner, null);
        }
    }
}
