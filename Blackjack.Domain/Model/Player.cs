using Blackjack.Domain.PublicIF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack.Domain.Model
{
    /// <summary>
    /// プレイヤー
    /// </summary>
    public class Player : PlayablePerson, IPlayable
    {
        public Player(int playerId, string handleName)
            : base(playerId, handleName){}

        /// <summary>
        /// ドロー後のハンドラメソッド
        /// </summary>
        /// <param name="cards">ドローして入手したカード</param>
        internal override void DidDraw(IEnumerable<Card> cards)
        {
            foreach(var elem in cards)
            {
                Console.WriteLine($"[Player] {elem.Suit}の{(int)elem.Number}");
            }
            Console.WriteLine($"[Player] 私の合計は{TotalValue}です");
        }

        /// <summary>
        /// バースト後のハンドラメソッド
        /// </summary>
        /// <param name="totalValue">バースト時の合計値</param>
        internal override void DidBurst(int totalValue)
        {
            Console.WriteLine($"[Player] バーストしました。私のバースト後の合計は{totalValue}です");
        }

    }
}
