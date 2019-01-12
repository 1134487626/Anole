using System;

namespace Anole
{
    /// <summary>
    /// 在继承至单例类的时候加上此标签为跨场景
    /// </summary>
    public class DontDestroyOnLoadAttribute : Attribute { }
}
