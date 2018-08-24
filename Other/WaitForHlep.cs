using System.Collections.Generic;
using UnityEngine;

namespace Anole
{
    /// <summary>
    /// 通用【WaitForSeconds】 协程延迟时间
    /// </summary>
    public sealed class WaitFor
    {
        private WaitFor() { }

        static Dictionary<float, WaitForSeconds> waitDic = new Dictionary<float, WaitForSeconds>();

        /// <summary>
        /// WaitForEndOfFrame
        /// </summary>
        public static WaitForEndOfFrame EndOfFrame { get; } = new WaitForEndOfFrame();

        /// <summary>
        /// WaitForSeconds
        /// </summary>
        /// <param name="r_Time"></param>
        /// <returns></returns>
        public static WaitForSeconds Seconds(float r_Time)
        {
            if (!waitDic.ContainsKey(r_Time))
            {
                waitDic.Add(r_Time, new WaitForSeconds(r_Time));
            }

            return waitDic[r_Time];
        }

    }
}
