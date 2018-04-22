using Blackjack.Domain.Service;
using Blackjack.Domain.Service.Policy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.Domain.Model
{
    /// <summary>
    /// Blackjackがプレイできるアクター向けの共通処理を提供します。
    /// </summary>
    public abstract class PlayablePerson
    {
        public PlayablePerson(int playerId, string handleName)
        {
            _playerId = playerId;
            _handleName = handleName;
            _hand = new Hand();
        }

        #region 公開メンバ
        /// <summary>
        /// プレイヤーのIDを取得します。
        /// </summary>
        public int PlayerId => _playerId;

        /// <summary>
        /// プレイヤーのハンドルネームを取得します。
        /// </summary>
        public string HandleName => _handleName;

        /// <summary>
        /// ドローした回数を取得します。
        /// </summary>
        public int DrawCount
        {
            get { return _drawCount; }
        }

        /// <summary>
        /// バーストしたか判定します。
        /// </summary>
        public bool IsBurst
        {
            get { return _hand.TotalValue > JudgementPolicy.MaximumTotalValue; }
        }

        /// <summary>
        /// 手札の合計値を取得します。
        /// </summary>
        public int TotalValue
        {
            get { return _hand.TotalValue; }
        }

        /// <summary>
        /// 初回のドローか判定します。
        /// </summary>
        /// <returns>初回のドローの場合はtrue, それ以外はfalse</returns>
        public bool IsFirstDraw
        {
            get { return _drawCount < 1; }
        }

        /// <summary>
        /// 現在のドローで引くカードの枚数を取得します。
        /// </summary>
        public int CurrentDrawCardCount
        {
            get { return IsFirstDraw ? 2 : 1; }
        }

        #endregion

        #region 公開メソッド
        /// <summary>
        /// ドローを行います。
        /// </summary>
        /// <param name="stock">山札</param>
        /// <returns>ドローしたカード</returns>
        public IEnumerable<Card> Draw(Stock stock)
        {
            PreDraw();

            var cards = stock.Draw(CurrentDrawCardCount);

            foreach(var c in cards)
            {
                _hand.AddCard(c);
                _drawCount++;
            }

            DidDraw(cards);
            return cards;
        }

        /// <summary>
        /// 手札に指定したカードを追加します。
        /// </summary>
        /// <param name="card">追加するカード</param>
        [Obsolete]
        public void AddCard(Card card)
        {
            _hand.AddCard(card);
        }

        /// <summary>
        /// ドロー数を設定します。
        /// </summary>
        /// <param name="drawCount">ドロー数</param>

        [Obsolete]
        public void SetDrawCount(int drawCount)
        {
            _drawCount = drawCount;
        }

        
        #endregion

        #region 非公開メンバ

        private int _playerId;
        private string _handleName;
        private int _drawCount;
        private Hand _hand;

        #endregion

        #region 非公開メソッド
        /// <summary>
        /// ドローの事前処理
        /// </summary>
        internal virtual void PreDraw() { }

        /// <summary>
        /// ドローの事後処理
        /// </summary>
        /// <param name="cards">ドローしたカード</param>
        internal virtual void DidDraw(IEnumerable<Card> cards) { }

        /// <summary>
        /// バーストが発生した時のハンドラメソッド
        /// </summary>
        /// <param name="totalValue">バースト時の合計</param>
        internal virtual void DidBurst(int totalValue) {}
        
        #endregion
    }
}
