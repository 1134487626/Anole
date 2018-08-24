using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Anole
{
    ///// <summary>
    ///// 基本扩展类通用型
    ///// </summary>
    //public static class HelpBasic
    //{
    //    /// <summary>
    //    /// 查找某个子对象的Buttom，并添加点击事件
    //    /// </summary>
    //    /// <param name="r_form"></param>
    //    /// <param name="r_path"></param>
    //    /// <param name="action"></param>
    //    /// <returns></returns>
    //    public static Button FindButtonAddAction(this Transform r_form, string r_path, UnityAction action)
    //    {
    //        if (r_form == null)
    //        {
    //            DeBug.LogError($">>>>>>>>>>> 注意：传入 Transform 为空");
    //            return null;
    //        }
    //        Button buttom = r_form.Find(r_path).GetComponent<Button>();
    //        if (buttom == null)
    //        {
    //            DeBug.LogError($">>>>>>>>>>> 注意：查找的子对象没有Buttom组件");
    //            return null;
    //        }

    //        buttom?.onClick.AddListener(action);
    //        return buttom;
    //    }

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <param name="r_form"></param>
    //    /// <param name="r_path"></param>
    //    /// <param name="action"></param>
    //    /// <returns></returns>
    //    public static Transform FindButtonAddAction2(this Transform r_form, string r_path, UnityAction action)
    //    {
    //        return r_form.FindButtonAddAction(r_path, action).transform;
    //    }
    //}
}
