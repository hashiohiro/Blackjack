using Blackjack.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.Domain.PublicIF
{
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
