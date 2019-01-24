using System;

namespace ClassLibrary1
{
    /// <summary>
    /// 功能类1
    /// </summary>
    public class Class1
    {
        /// <summary>
        /// 二个数据之和
        /// </summary>
        /// <param name="a">加数</param>
        /// <param name="b">被加数</param>
        /// <returns>返回二数据之和</returns>
        public Int32 Plus(Int32 a, Int32 b)
        {
            if (Int32.MaxValue - b - a > 0)
                return a + b;
            throw new ArgumentException("输入计算值超过了计算范围");
        }
    }
}
