using System;
using Xunit;
using FluentAssertions;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            var myHello = new WebApplication2.Controllers.Hello();
            var a = myHello.Get();
            Assert.Equal("Hi", a);
        }
    }
}
