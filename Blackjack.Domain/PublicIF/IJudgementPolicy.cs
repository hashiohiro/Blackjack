using Blackjack.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.Domain.PublicIF
{
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
