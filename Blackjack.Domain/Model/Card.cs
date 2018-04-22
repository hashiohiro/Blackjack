using Blackjack.Domain.Enum;
using Blackjack.Domain.PublicIF;
using Blackjack.Domain.Service;

namespace Blackjack.Domain.Model
{
    public class Card
    {

        public Card(Suit suit, CardNumber number)
        {
            Number = number;
            Suit = suit;
        }

        /// <summary>
        /// カード番号
        /// </summary>
        public CardNumber Number { get; private set; }

        /// <summary>
        /// カードのマーク
        /// </summary>
        public Suit Suit { get; private set; }

        /// <summary>
        /// カード価値ポリシー
        /// </summary>
        ICardValuePolicy cardValuePolicy = DomainContext.GetService<ICardValuePolicy>();

        /// <summary>
        /// カードの価値を取得する
        /// </summary>
        public int Value
        {
            get
            {
                return cardValuePolicy.GetValue(Number);
            }
        }
    }
}
