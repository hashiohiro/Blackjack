using Blackjack.Domain.PublicIF;
using System;
using System.Collections.Generic;
using System.Text;
using Blackjack.Domain.Model;

namespace Blackjack.Domain.Service.Policy
{
    public abstract class PlayablePersonTurnPolicy : IPlayablePersonTurnPolicy
    {
        public abstract bool NeedDraw(IPlayable playable);

        public bool Process(Stock stock, IPlayable playable)
        {
            while (NeedDraw(playable))
            {
                playable.Draw(stock);

                if (playable.IsBurst)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
