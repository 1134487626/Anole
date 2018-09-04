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
        /// <param name="time"></param>
        /// <returns></returns>
        public static WaitForSeconds Seconds(float time)
        {
            if (!waitDic.ContainsKey(time))
            {
                waitDic.Add(time, new WaitForSeconds(time));
            }
            return waitDic[time];
        }

    }
}
