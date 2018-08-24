using System;
using UnityEngine;

namespace Anole
{
    /// <summary>
    /// 打印Log
    /// </summary>
    public static class DeBug
    {
        /// <summary> 是否打印消息 </summary>
        public static bool isDebugLog { get; set; } = true;

        /// <summary>
        /// 获取当前时间
        /// </summary>
        public static string NowTime { get { return DateTime.Now.ToLocalTime().ToString(); } }

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
        public static void Log(string r_Info)
        {
            if (isDebugLog && r_Info != null) Debug.Log($"{NowTime}---：{r_Info}");
        }

        /// <summary>
        /// 打印系统的错误消息，并增加错误堆栈跟踪
        /// </summary>
        public static void LogError(string r_Info)
        {
            if (isDebugLog && r_Info != null)
            {
                Debug.LogError($"{NowTime}：{r_Info}\n { Environment.StackTrace}");
            }
        }

        /// <summary>
        /// 打印红色消息
        /// </summary>
        public static void LogRed(string r_Info)
        {
            if (isDebugLog && r_Info != null)
            {
                Debug.Log($"<color=#C30000FF>{NowTime}---：{r_Info}</color>");
            }
        }

        /// <summary>
        /// 打印蓝色消息
        /// </summary>
        public static void LogBull(string r_Info)
        {
            if (isDebugLog && r_Info != null)
            {
                Debug.Log($"<color=#0789B4FF>{NowTime}---：{r_Info}</color>");
            }
        }

        /// <summary>
        /// 打印紫色消息
        /// </summary>
        public static void LogViolet(string r_Info)
        {
            if (isDebugLog && r_Info != null)
            {
                Debug.Log($"<color=#A726F8FF>{NowTime}---：{r_Info}</color>");
            }
        }

        /// <summary>
        /// 打印橙色消息
        /// </summary>
        public static void LogOrange(string r_Info)
        {
            if (isDebugLog && r_Info != null)
            {
                Debug.Log($"<color=#D06009FF>{NowTime}---：{r_Info}</color>");
            }
        }

        /// <summary>
        /// 打印绿色消息
        /// </summary>
        public static void LogGreen(string r_Info)
        {
            if (isDebugLog && r_Info != null)
            {
                Debug.Log($"<color=#4FBC34FF>{NowTime} >>>>> ：{r_Info}</color>");
            }
        }

        /// <summary>
        /// 打印金黄色消息
        /// </summary>
        public static void LogGolden(string r_Info)
        {
            if (isDebugLog && r_Info != null)
            {
                Debug.Log($"<color=#D2C34DFF>{NowTime} >>>>> ：{r_Info}</color>");
            }
        }
    }
}
