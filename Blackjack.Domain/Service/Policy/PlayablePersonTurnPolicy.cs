using Blackjack.Domain.PublicIF;
using Blackjack.Domain.Model;

namespace Blackjack.Domain.Service.Policy
{
    /// <summary>
    /// プレイヤーのターンに行うことを定義します。
    /// </summary>
    public abstract class PlayablePersonTurnPolicy : IPlayablePersonTurnPolicy
    {
        /// <summary>
        /// ドローが必要か判定します。
        /// </summary>
        /// <returns>trueの場合はドローする。falseの場合はドローしない。</returns>
        public abstract bool NeedDraw(IPlayable playable);

        /// <summary>
        /// プレイヤーのターンに行う処理を定義します。
        /// </summary>
        /// <param name="stock">山札</param>
        /// <param name="playable">対象プレイヤー</param>
        /// <returns>バーストなし終了の場合はfalse、ありの場合はtrue</returns>
        public bool Process(Stock stock, IPlayable playable)
        {
            while (NeedDraw(playable))
            {
                playable.Draw(stock);

                if (playable.IsBurst)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
