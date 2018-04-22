using Blackjack.Domain.Enum;

namespace Blackjack.Domain.PublicIF
{
    /// <summary>
    /// カードの価値判断の基準を定義します。
    /// </summary>
    public interface ICardValuePolicy
    {
        /// <summary>
        /// ブラックジャックにおけるカードの価値を取得します。
        /// </summary>
        /// <param name="cardNumber">カード番号</param>
        /// <returns>カードの価値</returns>
        int GetValue(CardNumber cardNumber);
    }
}
