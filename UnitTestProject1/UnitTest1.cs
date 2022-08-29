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
            var asd = new Form1();

            
            Assert.NotNull(asd);
        }
    }
}
