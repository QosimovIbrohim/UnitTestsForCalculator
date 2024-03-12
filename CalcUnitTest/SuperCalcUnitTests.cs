using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace CalcUnitTest
{
    public class SuperCalcUnitTests
    {
        [Fact]
        public void TestAdd()
        {
            int x = 15;
            int y = 45;
            int exeptedValue = 60;

            int res = SuperCalculator.Add(x, y);

            Assert.Equal(exeptedValue, res);
        }

        [Theory]
        [InlineData(5, 6, 11)]
        [InlineData(1, 1, 2)]
        [InlineData(1, 9999, 10000)]
        public void TestAddWithTheory(int x, int y, int exVal)
        {
            int res = SuperCalculator.Add(x, y);
            Assert.Equal(res, exVal);
        }

        [Fact]
        public void TestSubstract()
        {
            int x = 10;
            int y = 5;
            int exval = 5;

            int res = SuperCalculator.Substract(x, y);

            Assert.Equal(exval, res);
        }


        [Theory]
        [InlineData(7, 2, 5)]
        [InlineData(200, 1, 199)]
        [InlineData(0, 2, -2)]
        public void TestSubstractWithTheory(int x, int y, int exVal)
        {
            int res = SuperCalculator.Substract(x, y);

            Assert.Equal(exVal, res);
        }

        [Fact]
        public void TestMultiple()
        {
            int x = 10;
            int y = 5;
            int exval = 50;

            int res = SuperCalculator.Multiple(x, y);

            Assert.Equal(exval, res);
        }

        [Theory]
        [InlineData(5, -1, -5)]
        [InlineData(0, 9, 0)]
        [InlineData(4, 1, 4)]
        public void TestMultipleWithTheory(int x, int y, int exVal)
        {
            int res = SuperCalculator.Multiple(x, y);

            Assert.Equal(exVal, res);
        }

        [Fact]
        public void TestDevide()
        {
            int x = 10;
            int y = 5;
            int exval = 2;

            int res = SuperCalculator.Devide(x, y);

            Assert.Equal(exval, res);
        }

        [Theory]
        [InlineData(10, 0, 0)]
        [InlineData(0, 10, 0)]
        [InlineData(50, 10, 5)]
        public void TestDevideWithTheory(int x, int y, int exVal)
        {
            if (y == 0)
            {
                Assert.Throws<DivideByZeroException>(() => SuperCalculator.Devide(x, y));
            }
            else
            {
                var res = SuperCalculator.Devide(x, y);
                Assert.Equal(exVal, res);
            }
        }
    }
}
