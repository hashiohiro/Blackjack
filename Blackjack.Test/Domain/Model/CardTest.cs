using Blackjack.Domain.Enum;
using Blackjack.Domain.Model;
using Blackjack.Domain.Service;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Blackjack.Test.Domain.Model
{
    public class CardTest
    {
        public CardTest()
        {
        }
        [Fact]
        public void Value_Test_Two()
        {
            var card = new Card(Suit.Club, CardNumber.Two);
            Assert.Equal(card.Value, 2);
        }

        [Fact]
        public void Value_Test_Three()
        {
            var card = new Card(Suit.Club, CardNumber.Three);
            Assert.Equal(card.Value, 3);
        }

        [Fact]
        public void Value_Test_Four()
        {
            var card = new Card(Suit.Club, CardNumber.Four);
            Assert.Equal(card.Value, 4);
        }

        [Fact]
        public void Value_Test_Five()
        {
            var card = new Card(Suit.Club, CardNumber.Five);
            Assert.Equal(card.Value, 5);
        }

        [Fact]
        public void Value_Test_Six()
        {
            var card = new Card(Suit.Club, CardNumber.Six);
            Assert.Equal(card.Value, 6);
        }

        [Fact]
        public void Value_Test_Seven()
        {
            var card = new Card(Suit.Club, CardNumber.Seven);
            Assert.Equal(card.Value, 7);
        }

        [Fact]
        public void Value_Test_Eight()
        {
            var card = new Card(Suit.Club, CardNumber.Eight);
            Assert.Equal(card.Value, 8);
        }

        [Fact]
        public void Value_Test_Nine()
        {
            var card = new Card(Suit.Club, CardNumber.Nine);
            Assert.Equal(card.Value, 9);
        }

        [Fact]
        public void Value_Test_Ten()
        {
            var card = new Card(Suit.Club, CardNumber.Ten);
            Assert.Equal(card.Value, 10);
        }

        [Fact]
        public void Value_Test_Jack()
        {
            var card = new Card(Suit.Club, CardNumber.Jack);
            Assert.Equal(card.Value, 10);
        }

        [Fact]
        public void Value_Test_Queen()
        {
            var card = new Card(Suit.Club, CardNumber.Queen);
            Assert.Equal(card.Value, 10);
        }

        [Fact]
        public void Value_Test_King()
        {
            var card = new Card(Suit.Club, CardNumber.King);
            Assert.Equal(card.Value, 10);
        }

        [Fact]
        public void Value_Test_Ace()
        {
            var card = new Card(Suit.Club, CardNumber.Ace);
            Assert.Equal(card.Value, 1);
        }
    }
}
