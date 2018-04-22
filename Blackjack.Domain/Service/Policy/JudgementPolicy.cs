using Blackjack.Domain.PublicIF;
using System;
using System.Collections.Generic;
using System.Text;
using Blackjack.Domain.Model;

namespace Blackjack.Domain.Service.Policy
{
    public class JudgementPolicy : IJudgementPolicy
    {
        /// <summary>
        /// 合計値の上限
        /// </summary>
        public static readonly int MaximumTotalValue = 21;

        public IPlayable Judge(Dealer dealer, Player player)
        {
            var d = MaximumTotalValue - player.TotalValue;
            var p = MaximumTotalValue - dealer.TotalValue;

            // 引き分け判定
            if (d == p)
            {
                return null;
            }

            // 値が小さいほうが勝ち
            return d > p ? (IPlayable)player : dealer;
        }

    }
}
