using MyClassLibrary;
using System;
using Xunit;

namespace MyXUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Add()
        {
            var calculation = new Calculation();
            var result = calculation.Add(2, 3);
            Assert.Equal(5, result);
        }
    }
}
