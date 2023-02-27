using System.ComponentModel;

namespace PD.Platform.Utils
{
    /// <summary>
    /// 属性值变动事件参数
    /// </summary>
    public class PropertyChangedArgs : PropertyChangedEventArgs
    {
        /// <summary>
        ///  变更前的值
        /// </summary>
        public object OriginalValue { get; }

        /// <summary>
        /// 变更后的值
        /// </summary>
        public object NewValue { get; }

        /// <summary>
        ///  属性值变动事件参数
        /// </summary>
        /// <param name="propertyName">属性名称</param>
        /// <param name="originalVal">变更前的值</param>
        /// <param name="newVal">变更后的值</param>
        public PropertyChangedArgs(string propertyName, object originalVal, object newVal)
            : base(propertyName)
        {
            OriginalValue = originalVal;
            NewValue = newVal;
        }
    }
}
