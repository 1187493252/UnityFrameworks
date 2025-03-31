/*
* FileName:          FrameworkEventArgs 
* CompanyName:       
* Author:            relly
* Description:       
* 
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Framework
{
    /// <summary>
    /// 框架中包含事件数据的类的基类。
    /// </summary>
    public abstract class FrameworkEventArgs : EventArgs, IReference
    {
        /// <summary>
        /// 初始化框架中包含事件数据的类的新实例。
        /// </summary>
        public FrameworkEventArgs()
        {

        }

        /// <summary>
        /// 清理引用。
        /// </summary>
        public abstract void Clear();
    }
}