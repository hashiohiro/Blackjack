using Xunit;

using Blackjack.Domain.Enum;
using Blackjack.Domain.Model;

namespace Blackjack.Test.Domain.Model
{
    public class HandTest
    {
        [Fact]
        public void Test_AddCard()
        {
            var hand = new Hand();
            hand.AddCard(new Card(Suit.Club, CardNumber.Ace));
            hand.AddCard(new Card(Suit.Club, CardNumber.King));
            hand.AddCard(new Card(Suit.Club, CardNumber.Queen));
            Assert.Equal(3, hand.Count);
        }

        [Fact]
        public void Test_TotalValue()
        {
            var hand = new Hand();
            hand.AddCard(new Card(Suit.Club, CardNumber.Ace));
            hand.AddCard(new Card(Suit.Club, CardNumber.King));
            hand.AddCard(new Card(Suit.Club, CardNumber.Queen));

            Assert.Equal(21, hand.TotalValue);
        }
    }
}
