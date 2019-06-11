using System;
using System.Collections.Generic;
using System.Text;
using Taschenrechner;
using Xunit;

namespace GrundRechnerTest
{
    public class TestGeomitry
    {
        [Fact]
        public void TestArea()
        {
            Assert.True(new TestGeo().TestArea(5) == 157.07963267948966192313216);
        }
        [Fact]
        public void Testsin()
        {
            Assert.True(new TestGeo().testsin(12) == 0.20791169081775933710174228440513);
        }
        [Fact]
        public void Testcos()
        { 
            Assert.True(new TestGeo().testcos(12) == 0.97814760073380558);
        }
        [Fact]
        public void radtest()
        {
            Assert.True(new TestGeo().CircleRadus(120) == 6.1803872323710367);
        }
    }
    class TestGeo : Geometrie
    {
        public double TestArea(double r)
        {
            return Area_Circle(r);
        }
        public double testsin(double x)
        {
            return sin(x);
        }
        public double CircleRadus(double u)
        {
            return Radius_Circle(u);
        }
        public double testcos(double x)
        {
            return cos(x);
        }
    }
}
