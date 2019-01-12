using System;
using UnityEngine;

namespace Anole
{
    /// <summary>
    /// MonoBehaviour组件式单例类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SingtonBehaviour<T> : MonoBehaviour where T : MonoBehaviour
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
                    GameObject obj = new GameObject(typeof(T).FullName);
                    m_Instance = obj.AddComponent<T>();
                    obj.SendMessage(nameof(OnBehaviour));

                    Type type = typeof(T);
                    System.Object[] objs = type.GetCustomAttributes(typeof(DontDestroyOnLoadAttribute), false);
                    if (objs?.Length > 0) DontDestroyOnLoad(obj);                    
                }
                return m_Instance;
            }
        }

        /// <summary>
        /// [Awake] => [OnBehaviour] => [Start]
        /// </summary>
        protected virtual void OnBehaviour() { }

    }
}
