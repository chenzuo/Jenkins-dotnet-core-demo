using System;
using Xunit;

namespace XUnitTestProject1
{
    /// <summary>
    /// 测试方法
    /// </summary>
    public class UnitTest1
    {
        /// <summary>
        /// 测试方法一
        /// </summary>
        [Fact]
        public void Test1()
        {
            ClassLibrary1.Class1 class1 = new ClassLibrary1.Class1();
            var plus = class1.Plus(1, 2);
            Assert.Equal(3, plus);
            plus = class1.Plus(1, 3);
            Assert.Equal(4, plus);
        }
    }
}
