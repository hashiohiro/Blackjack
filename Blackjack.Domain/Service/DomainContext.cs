using Blackjack.Domain.PublicIF;
using Blackjack.Domain.Service.Policy;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.Domain.Service
{
    public static class DomainContext
    {
        private static readonly Container container;

        static DomainContext()
        {
            if (container is null)
            {
                container = new Container();
                Setup();
            }
        }

        /// <summary>
        /// サービスを取得します。
        /// </summary>
        /// <typeparam name="TService">サービスの型</typeparam>
        /// <returns>サービスのインスタンス</returns>
        public static TService GetService<TService>()
            where TService : class
        {
            return container.GetInstance<TService>();
        }

        /// <summary>
        /// サービスを取得します。
        /// </summary>
        /// <param name="serviceType">サービスの型</param>
        /// <returns>サービスのインスタンス</returns>
        public static object GetService(Type serviceType)
        {
            return container.GetInstance(serviceType);
        }

        /// <summary>
        /// コンテナを設定します。
        /// </summary>
        private static void Setup()
        {
            container.Register<ICardValuePolicy, SimpleCardValuePolicy>();
            container.Register<IJudgementPolicy, JudgementPolicy>();
            container.Register<DealerTurnPolicy, DealerTurnPolicy>();
            container.Register<PlayerTurnPolicy, PlayerTurnPolicy>();
            container.Verify();
        }
    }
}
