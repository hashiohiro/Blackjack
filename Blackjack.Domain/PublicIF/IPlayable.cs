using System.Collections.Generic;

using Blackjack.Domain.Model;

namespace Blackjack.Domain.PublicIF
{
    /// <summary>
    /// ブラックジャックをプレイできるアクターを表します。
    /// </summary>
    public interface IPlayable
    {
        /// <summary>
        /// プレイヤーを一意に識別するID
        /// </summary>
        int PlayerId { get; }

        /// <summary>
        /// プレイヤーのハンドル名
        /// </summary>
        string HandleName { get; }

        /// <summary>
        /// 山札からカードをドローします。
        /// </summary>
        /// <returns>初回のドローの場合は2枚のカードを、それ以外のドローは1枚のカードを返す</returns>
        IEnumerable<Card> Draw(Stock stock);

        /// <summary>
        /// バースト有無を判定します。
        /// </summary>
        /// <returns></returns>
        bool IsBurst { get; }
    }
}
