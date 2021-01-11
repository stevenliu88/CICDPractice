using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void TestValue()
        {
            var result = controller.Get(2);
            Assert.Equal("test",result.Value);
        }
        [Fact]
        public void Test1()
        {
            Assert.Equal(3,3);
        }
    }
}
