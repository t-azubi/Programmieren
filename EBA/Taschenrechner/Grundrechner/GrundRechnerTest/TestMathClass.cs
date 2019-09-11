using System;
using System.Linq.Expressions;
using System.Net.WebSockets;
using Taschenrechner;
using Xunit;

namespace GrundRechnerTest
{
    public class TestMathClass
    {
        [Fact]
        public void Power2()
        {
            Assert.True(new MathTest().power(2, 2) == 4);
            Assert.True(new MathTest().power(5, 2) == 25);
            Assert.True(new MathTest().power(12, 2) == 144);
        }
        [Fact]
        public void PowerNeg2()
        {
            Assert.True(new MathTest().power(2, -2) == 0.25);
            Assert.True(new MathTest().power(5, -2) == 0.04);
        }
        [Theory]
        [InlineData(0.75,0,3,4)]
        [InlineData(0.22,0, 11, 50)]
        [InlineData(1.66, 1, 33, 50)]
        public void doubleToFraction(double input,int whole, int top, int bottom)
        {
            var result = new MathCalc().DoubleToFraction(input);
            Assert.True(whole == result.Item1);
            Assert.True(top == result.Item2);
            Assert.True(bottom == result.Item3);
        }
        [Fact]
        public void Power10()
        {
            Assert.True(new MathTest().power(2, 10) == 1024);
            Assert.True(new MathTest().power(5, 10) == 9765625);
        }
        [Fact]
        public void Root2()
        {
            Assert.True(new MathTest().RootTest(2, 9) == 3);
            Assert.True(new MathTest().RootTest(2, 36) == 6);
        }
        [Fact]
        public void Root3()
        {
            Assert.True(new MathTest().RootTest(3, 27) == 3);
            Assert.True(new MathTest().RootTest(3, 1000) == 10);
        }
        [Fact]
        public void LN2()
        {
            Assert.True(new MathTest().naturalLN(2) == 0.69314718055994506);
        }
        [Fact]
        public void Faku5()
        {
            Assert.True(new MathTest().FakultätTest(5) == 120);
        }
        [Fact]
        public void LOG()
        {
            Assert.True(new MathTest().LOGTest(10, 10) == 1);
        }
    }
    public class MathTest : MathCalc
    {
        public double power(double x, double y)
        {
            return Power(x, y);
        }
        public double naturalLN(double x)
        {
            return LN(x);
        }
        public double LOGTest(double x, double y)
        {
            return LOG(x, y);
        }
        public int FakultätTest(int x)
        {
            return factorial(x);
        }
        public double RootTest(int x, double y)
        {
            return root(x, y);
        }
    }
    public class TestKonst
    {
        [Fact]
        public void EulerischerZahl()
        {
            var e = new KonstantenTest().e;
            Assert.True(e == 2.7182818284590451);
        }

        [Fact]
        public void Pi()
        {
            var pi = new KonstantenTest().pi;
            Assert.True(pi == 3.1415926535897931);
        }
        [Fact]
        public void GoldenerSchnitt()
        {
            var φ = new KonstantenTest().φ;
            Assert.True(φ == 1.6180339887498949);
        }
    }
    public class KonstantenTest : Konstanten
    {

    }
}
