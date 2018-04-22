using Blackjack.Domain.PublicIF;
using System;
using System.Collections.Generic;
using System.Text;
using Blackjack.Domain.Model;

namespace Blackjack.Domain.Service.Policy
{
    public class DealerTurnPolicy : PlayablePersonTurnPolicy 
    {
        public override bool NeedDraw(IPlayable playable)
        {
            return (playable as Dealer).NeedDraw;
        }
    }
}
