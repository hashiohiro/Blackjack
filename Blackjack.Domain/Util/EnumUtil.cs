using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack.Domain.Util
{
    public static class EnumUtil
    {
        public static List<T> GetElements<T>()
        {
            var ary = (T[])System.Enum.GetValues(typeof(T));
            return new List<T>(ary);
        }

        public static T GetElement<T>(int num)
        {
            return (T)System.Enum.ToObject(typeof(T), num);
        }
    }
}
