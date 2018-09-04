using System;
using UnityEngine;

namespace Anole
{
    /// <summary>
    /// MonoBehaviour组件式单例类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MonoBehaviourSington<T> : MonoBehaviour where T : MonoBehaviour
    {
        /// <summary>
        /// this
        /// </summary>
        protected static T m_Instance;

        /// <summary>
        /// MonoBehaviour组件式
        /// </summary>
        public static T instance
        {
            get
            {
                if (m_Instance == null)
                {
                    GameObject obj = new GameObject(m_Instance.GetType().FullName);
                    m_Instance = obj.AddComponent<T>();
                    IsDontOnLoad(obj);
                }
                return m_Instance;
            }
        }

        /// <summary>
        /// 查看此类的标签是否为切换场景不移除
        /// </summary>
        /// <param name="obj"></param>
        private static void IsDontOnLoad(GameObject obj)
        {
            Type type = typeof(T);
            System.Object[] objAry = type.GetCustomAttributes(false);

            if (objAry?.Length > 0)
            {
                for (int i = 0; i < objAry.Length; i++)
                {
                    if (objAry[i] == null) continue;

                    if (objAry[i] is DontDestroyOnLoadAttribute)
                    {
                        DontDestroyOnLoad(obj);
                        return;
                    }
                }
            }
        }
    }
}
