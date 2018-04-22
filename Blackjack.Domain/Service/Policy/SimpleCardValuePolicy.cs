using Blackjack.Domain.PublicIF;
using System;
using System.Collections.Generic;
using System.Text;
using Blackjack.Domain.Enum;

namespace Blackjack.Domain.Service.Policy
{
    public class SimpleCardValuePolicy : ICardValuePolicy
    {
        public int GetValue(CardNumber cardNumber)
        {
            switch (cardNumber)
            {
                case CardNumber.Jack:
                case CardNumber.King:
                case CardNumber.Queen:
                    return 10;
                
                default:
                    return (int)cardNumber;
            }
        }
    }
}
