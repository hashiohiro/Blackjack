using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack.Domain.Model
{
    /// <summary>
    /// 手札
    /// </summary>
    public class Hand
    {
        public Hand()
        {
            cards = new List<Card>();
        }
        private List<Card> cards;

        /// <summary>
        /// 手札にカードを追加します。
        /// </summary>
        /// <param name="card">カード</param>
        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        /// <summary>
        /// 手札のカード枚数を取得します。
        /// </summary>
        public int Count => cards.Count();

        /// <summary>
        /// 手持ちのカードの合計を求めます。
        /// </summary>
        public int TotalValue
        {
            get { return cards.Sum(x => x.Value); }
        }

        
    }
}
