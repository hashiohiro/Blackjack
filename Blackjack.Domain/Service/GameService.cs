using Blackjack.Domain.Model;
using Blackjack.Domain.PublicIF;
using Blackjack.Domain.Service;
using Blackjack.Domain.Service.Policy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.Domain.Service
{
    public class GameService
    {
        public GameService()
        {
            Init();
        }

        private Stock stock;
        private Player player;
        private Dealer dealer;
        private IJudgementPolicy judgementPolicy;
        private PlayerTurnPolicy playerTurnPolicy;
        private DealerTurnPolicy dealerTurnPolicy;

        

        public IPlayable Execute()
        {
            DrawOnFirstTime();

            if (playerTurnPolicy.Process(stock, player))
            {
                player.DidBurst(player.TotalValue);
                return dealer;
            }

            if (dealerTurnPolicy.Process(stock, dealer))
            {
                dealer.DidBurst(dealer.TotalValue);
                return player;
            }

            return Judge();
        }

        /// <summary>
        /// ゲームを初期化する。
        /// </summary>
        protected void Init()
        {
            stock = new Stock();
            player = new Player(1, "MurabitoA");
            dealer = new Dealer(1, "MurabitoB");
            judgementPolicy = DomainContext.GetService<IJudgementPolicy>();
            playerTurnPolicy = DomainContext.GetService<PlayerTurnPolicy>();
            dealerTurnPolicy = DomainContext.GetService<DealerTurnPolicy>();
        }

        /// <summary>
        /// 初回のドロー
        /// </summary>
        protected void DrawOnFirstTime()
        {
            player.Draw(stock);
            dealer.Draw(stock);
        }

        /// <summary>
        /// 勝敗の判定を行う
        /// </summary>
        /// <returns>勝者</returns>
        protected IPlayable Judge()
        {
            return judgementPolicy.Judge(dealer, player);
        }
    }
}
