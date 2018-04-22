using Blackjack.Domain.Enum;
using Blackjack.Domain.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack.Domain.Model
{
    /// <summary>
    /// 山札
    /// </summary>
    public class Stock
    {
        public Stock()
        {
            Init();
        }

        private List<Card> cards;


        /// <summary>
        /// 山札から指定された枚数ぶんカードを引きます。
        /// </summary>
        /// <param name="cardCount">引くカードの枚数</param>
        /// <returns>引いたカード</returns>
        public IEnumerable<Card> Draw(int cardCount)
        {
            var cs = cards.Take(cardCount);
            cards.RemoveRange(0, cardCount);
            return cs;
        }

        /// <summary>
        /// 山札の枚数を取得します。
        /// </summary>
        public int Count
        {
            get { return cards.Count(); }
        }

        /// <summary>
        /// 山札をシャッフルします。
        /// </summary>
        public void Shuffle()
        {
            cards = cards.OrderBy(x => Guid.NewGuid()).ToList();
        }

        private void Init()
        {
            cards = CreateCards();
        }

        /// <summary>
        /// 山札の初期状態を生成します。
        /// </summary>
        /// <returns>山札の初期状態</returns>
        private List<Card> CreateCards()
        {
            var cardNums = EnumUtil.GetElements<CardNumber>();
            var suits = EnumUtil.GetElements<Suit>();

            return suits.SelectMany(su => cardNums.Select(num => new Card(su, num))).ToList();
        }
    }
}
