using System;
using System.Collections.Generic;
using System.Linq;

using Blackjack.Domain.PublicIF;

namespace Blackjack.Domain.Model
{
    public class Dealer : PlayablePerson, IPlayable
    {
        public Dealer(string handleName) : base(0, handleName) { }
        /// <summary>
        /// ドローを続けなければならない値
        /// </summary>
        private const int NeedDrawValue = 17;

        /// <summary>
        /// Dealerに割り当てられるPlayerIDは常に0
        /// </summary>
        private const int PlayerIdForDealer = 0;

        public Dealer(int dealerId, string handleName)
            : base(PlayerIdForDealer, handleName)
        {
            this.dealerId = dealerId;
        }

        private int dealerId;
        
        /// <summary>
        /// ディーラーのドローが必要か判定します。
        /// </summary>
        /// <returns>trueの場合はドローが必要。falseの場合はドローが不要。</returns>
        public bool NeedDraw
        {
            get { return TotalValue < NeedDrawValue; }
        }

        /// <summary>
        /// ドロー後のハンドラメソッド
        /// </summary>
        /// <param name="cards">ドローして入手したカード</param>
        internal override void DidDraw(IEnumerable<Card> cards)
        {
            foreach(var i in Enumerable.Range(0, cards.Count()))
            {
                var elem = cards.ElementAt(i);

                if (i > 0)
                {
                    Console.WriteLine($"[Dealer] : 何を引いたかは内緒です。");
                    return;
                }
                Console.WriteLine($"[Dealer] : {elem.Suit}の{(int)elem.Number}を引きました。");
            }
        }

        /// <summary>
        /// バースト後のハンドラメソッド
        /// </summary>
        /// <param name="totalValue">バースト時の合計値</param>
        internal override void DidBurst(int totalValue)
        {
            Console.WriteLine($"[Dealer] バーストしました。私のバースト後の合計は{totalValue}です");
        }
    }
}
