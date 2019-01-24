using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ClassLibrary1.Class1 class1 = new ClassLibrary1.Class1();
            var plus = class1.Plus(1, 2);
            Assert.Equal(3, plus);
        }
    }
}
