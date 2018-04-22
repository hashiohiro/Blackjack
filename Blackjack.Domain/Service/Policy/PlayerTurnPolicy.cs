using Blackjack.Domain.Model;
using Blackjack.Domain.PublicIF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.Domain.Service.Policy
{
    public class PlayerTurnPolicy : PlayablePersonTurnPolicy
    {
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
