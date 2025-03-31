/*
* FileName:          ILogHelper
* CompanyName:  
* Author:            
* Version:           1.0
* Description:       
* 
*/


namespace Framework
{
    /// <summary>
    /// 框架日志辅助器接口。
    /// </summary>
    public interface ILogHelper
    {
        /// <summary>
        /// 记录日志。
        /// </summary>
        /// <param name="level">游戏框架日志等级。</param>
        /// <param name="message">日志内容。</param>
        void Log(FrameworkLogLevel level, object message);
    }
}