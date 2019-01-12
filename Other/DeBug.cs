using System;
using UnityEngine;

namespace Anole
{
    /// <summary>
    /// 打印Log
    /// </summary>
    public static class DeBug
    {
        /// <summary>
        /// 是否打印消息
        /// </summary>
        public static bool isDebugLog { get; set; } = true;

        /// <summary>
        /// 获取当前系统时间
        /// </summary>
        public static string PrefixTime { get { return DateTime.Now.ToLocalTime().ToString(); } }

        /*
         * 紫色 = "<color=#A726F8FF>"
         * 蓝色 = "<color=#0789B4FF>"
         * 绿色 = "<color=#4FBC34FF>"
         * 黄色 = "<color=#D2C34DFF>"
         * 橙色 = "<color=#D06009FF>"
         */

        /// <summary>
        /// 正常代替打印输出
        /// </summary>
        public static void Log(string log)
        {
            if (isDebugLog && log != null) Debug.Log($"{PrefixTime}{log}");
        }

        /// <summary>
        /// 打印系统的错误消息
        /// </summary>
        /// <param name="log"></param>
        /// <param name="isStackTrace">是否错误堆栈跟踪</param>
        public static void LogError(string log, bool isStackTrace = false)
        {
            if (isDebugLog && log != null)
            {
                if (isStackTrace)
                {
                    Debug.LogError($"{PrefixTime}{log}\n { Environment.StackTrace}");
                }
                else
                {
                    Debug.LogError($"{PrefixTime}{log}");
                }
            }
        }

        /// <summary>
        /// 打印错误堆栈跟踪
        /// </summary>
        /// <param name="log"></param>
        public static void StackTrace(string log)
        {
            if (isDebugLog && log != null)
            {
                Debug.Log($"{PrefixTime}{log}\n { Environment.StackTrace}");
            }
        }

        /// <summary>
        /// 打印蓝色消息
        /// </summary>
        public static void LogBull(string log)
        {
            if (isDebugLog && log != null)
            {
                Debug.Log($"<color=#0789B4FF>{PrefixTime}{log}</color>");
            }
        }

        /// <summary>
        /// 打印紫色消息
        /// </summary>
        public static void LogViolet(string log)
        {
            if (isDebugLog && log != null)
            {
                Debug.Log($"<color=#A726F8FF>{PrefixTime}{log}</color>");
            }
        }

        /// <summary>
        /// 打印橙色消息
        /// </summary>
        public static void LogOrange(string log)
        {
            if (isDebugLog && log != null)
            {
                Debug.Log($"<color=#D06009FF>{PrefixTime}{log}</color>");
            }
        }

        /// <summary>
        /// 打印绿色消息
        /// </summary>
        public static void LogGreen(string log)
        {
            if (isDebugLog && log != null)
            {
                Debug.Log($"<color=#4FBC34FF>{PrefixTime}{log}</color>");
            }
        }

        /// <summary>
        /// 打印金黄色消息
        /// </summary>
        public static void LogGolden(string log)
        {
            if (isDebugLog && log != null)
            {
                Debug.Log($"<color=#D2C34DFF>{PrefixTime}{log}</color>");
            }
        }
    }
}
