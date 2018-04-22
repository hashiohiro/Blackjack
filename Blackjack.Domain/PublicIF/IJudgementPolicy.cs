using Blackjack.Domain.Model;

namespace Blackjack.Domain.PublicIF
{
    /// <summary>
    /// 勝敗の判断基準を定義します。
    /// </summary>
    public interface IJudgementPolicy
    {
        /// <summary>
        /// 勝敗を判定します。
        /// </summary>
        /// <param name="dealer">ディーラー</param>
        /// <param name="player">プレイヤー</param>
        /// <returns>勝者のオブジェクト</returns>
        IPlayable Judge(Dealer dealer, Player player);
    }
}
