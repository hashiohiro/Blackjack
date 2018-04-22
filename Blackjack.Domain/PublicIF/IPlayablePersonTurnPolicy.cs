using Blackjack.Domain.Model;

namespace Blackjack.Domain.PublicIF
{
    /// <summary>
    /// プレイヤーのターンに行うことを定義します。
    /// </summary>
    public interface IPlayablePersonTurnPolicy
    {
        /// <summary>
        /// プレイヤーのターンに行う処理を定義します。
        /// </summary>
        /// <param name="stock">山札</param>
        /// <param name="playable">対象プレイヤー</param>
        /// <returns>バーストなし終了の場合はfalse、ありの場合はtrue</returns>
        bool Process(Stock stock, IPlayable playable);

        /// <summary>
        /// ドローが必要か判定します。
        /// </summary>
        /// <returns>trueの場合はドローする。falseの場合はドローしない。</returns>
        bool NeedDraw(IPlayable playable);
    }
}
