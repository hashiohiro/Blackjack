using Blackjack.Domain.PublicIF;
using Blackjack.Domain.Enum;

namespace Blackjack.Domain.Service.Policy
{
    /// <summary>
    /// シンプルなカードの価値判断ポリシーです。
    /// </summary>
    /// <remarks>
    /// カードの種類ごとに価値を算出します。
    /// プレイヤーが引いたカードの合計をこの値を基に計算します。
    /// </remarks>
    public class SimpleCardValuePolicy : ICardValuePolicy
    {
        public int GetValue(CardNumber cardNumber)
        {
            switch (cardNumber)
            {
                case CardNumber.Jack:
                case CardNumber.King:
                case CardNumber.Queen:
                    return 10;
                
                default:
                    return (int)cardNumber;
            }
        }
    }
}
