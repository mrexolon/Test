using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    [TestFixture]
  public  class DivTest
    {
        [Test]
        public void DivTest1()
        {
            double result = Calc.Div(15, 2);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void DivTest2()
        {
            Assert.Throws(typeof(DivideByZeroException), delegate { Calculator.Division(15, 0); });
        }
        [Test]
        public void DivTest3()
        {
            double result = Calc.Div(43, 32);
            Assert.IsNotNull(result);
        }
        [Test]
        public void DivTest4()
        {
            double result = Calc.Div(5.53, 3);
            double result1 = Calc.Div(5.53, 3);
            Assert.AreEqual(result, result1);
        }
        [Test]
        public void DivTest5()
        {
            Assert.IsNaN(Calc.Div(Double.NaN, 445));
        }

    }
}
