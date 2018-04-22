using System.Collections.Generic;

namespace Blackjack.Domain.Util
{
    /// <summary>
    /// 列挙体操作の便利なメソッドを提供します。
    /// </summary>
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
