using System;
using UnityEngine;

namespace Anole
{
    /// <summary>
    /// 实例化对象单例类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Sington<T> : MonoBehaviour where T : MonoBehaviour
    {
        /// <summary>
        /// this
        /// </summary>
        protected static T m_Instance;

        /// <summary>
        /// 动态创建一个对象的实例组件
        /// </summary>
        public static T instance
        {
            get
            {
                if (m_Instance == null)
                {
                    GameObject obj = new GameObject();
                    m_Instance = obj.AddComponent<T>();
                    obj.name = m_Instance.GetType().Name;
                    IsDontOnLoad(obj);
                }

                return m_Instance;
            }
        }

        /// <summary>
        /// 查看此类的标签是否为切换场景不移除
        /// </summary>
        /// <param name="r_obj"></param>
        private static void IsDontOnLoad(GameObject r_obj)
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
                        DontDestroyOnLoad(r_obj);
                        return;
                    }
                }
            }
        }
    }
}
