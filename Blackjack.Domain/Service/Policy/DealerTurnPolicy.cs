using Blackjack.Domain.PublicIF;
using Blackjack.Domain.Model;

namespace Blackjack.Domain.Service.Policy
{
    /// <summary>
    /// ディーラーのターンに行うことを定義します。。
    /// </summary>
    public class DealerTurnPolicy : PlayablePersonTurnPolicy 
    {
        /// <summary>
        /// ドローが必要か判定します。
        /// </summary>
        /// <returns>trueの場合はドローする。falseの場合はドローしない。</returns>
        public override bool NeedDraw(IPlayable playable)
        {
            return (playable as Dealer).NeedDraw;
        }
    }
}
