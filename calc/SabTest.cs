using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    [TestFixture]
   public class SabTest
    {
        public void SubsTest1()
        {
            double result = Calc.Sub(43, 3);
            Assert.AreEqual(49, result);

        }
        [Test]
        public void SubsTest2()
        {
            double result = Calc.Sub(43, 3);
            Assert.IsNotNull(result);
        }
        [Test]
        public void SubsTest3()
        {
            Assert.IsNaN(Calc.Sub(Double.NaN, 666));
        }
    }
}
