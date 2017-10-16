using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Calc
    {
        public static double Add(double first, double second)
        {
            return first + second;
        }
        public static double Sub(double first, double second)
        {
            return first - second;
        }
        public static double Div(double first, double second)
        {
            if (second == 0) throw new DivideByZeroException();
            return first / second;
        }
        public static double Multi(double first, double second)
        {
            return first * second;
        }
    }
}
