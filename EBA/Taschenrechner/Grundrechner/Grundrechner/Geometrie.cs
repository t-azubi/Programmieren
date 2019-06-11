using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
  public  class Geometrie
    {
        public static double Area_Circle(double radius)
        {
            double area = 2 * (new Konstanten().pi * (radius * radius));
            return area;
        }
        public static double Radius_Circle(double area)
        {
            double radius = new MathCalc().root(2,new Grundrechner().CalcConst(area.ToString() + "/" + new Konstanten().pi.ToString()) ) ;
            return radius;
        }
       public double sin(double x)
        {
            double sign = 1;
            if (x < 0)
            {
                sign = -1.0;
                x = -x;
            }
            if (x > 360) x -= (x / 360) * 360;
            x *= new Konstanten().pi / 180.0;
            double res = 0;
            double term = x;
            int k = 1;
            while (res + term != res)
            {
                res += term;
                k += 2;
                term *= -x * x / k / (k - 1);
            }
            return sign * res;
        }

       public double cos(double x)
        {
            if (x < 0) x = -x;
            if (x > 360) x -= (x / 360) * 360;
            x *= new Konstanten().pi  / 180.0;
            double res = 0;
            double term = 1;
            int k = 0;
            while (res + term != res)
            {
                res += term;
                k += 2;
                term *= -x * x / k / (k - 1);
            }
            return res;
        }
    }
}
