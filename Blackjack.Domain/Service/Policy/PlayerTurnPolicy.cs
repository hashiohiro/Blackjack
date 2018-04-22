using System;

using Blackjack.Domain.PublicIF;

namespace Blackjack.Domain.Service.Policy
{
    /// <summary>
    /// プレイヤーのターンに行うことを定義します。
    /// </summary>
    public class PlayerTurnPolicy : PlayablePersonTurnPolicy
    {
        /// <summary>
        /// ドローが必要か判定します。
        /// </summary>
        /// <returns>trueの場合はドローする。falseの場合はドローしない。</returns>
        public override bool NeedDraw(IPlayable playable)
        {
            Console.Write("ドローする? : [Y/n]");
            var cmd = Console.ReadLine();

            switch (cmd.Trim().ToLower())
            {
                case "n":
                    return false;
                case "y":
                default:
                    return true;
            }
        }
    }
}
