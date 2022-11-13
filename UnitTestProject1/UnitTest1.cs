using System;
using System.Linq;
using Xunit;
using WindowsFormsApp1;

namespace UnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            Assert.True(true);

        }

        [Fact]
        public void TestMethod2()
        {          
            Assert.True(1>2);
        }
    }
}
