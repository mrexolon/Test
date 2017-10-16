using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    [TestFixture]
    public class MutliTest
    {
        [Test]
        public void MultiTest1()
        {
            double result = Calc.Multi(2, 3);
            Assert.AreEqual(6, result);
        }
        [Test]
        public void MultiTest2()
        {
            double result = Calc.Multi(2, 3);
            Assert.IsNotNull(result);
        }
        [Test]
        public void MultiTest3()
        {
            Assert.IsNaN(Calc.Multi(Double.NaN, 445));
        }
    }
}
