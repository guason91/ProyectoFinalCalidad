using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.TEST
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Carlos Solorzano", returnValue.Value);
        }

        [Fact]
        public void GetReturnsValor()
        {
            var returnValue = controller.Get(2);
            Assert.Equal("150", returnValue.Value);
        }

        [Fact]
        public void GetReturnsResultado()
        {
            var returnValue = controller.Get(3);
            Assert.Equal("Operado correctamente", returnValue.Value);
        }

        [Fact]
        public void GetReturnsError()
        {
            var returnValue = controller.Get(4);
            Assert.Equal("ERROR", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
