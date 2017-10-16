using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calc
{
    [TestFixture]
    public class AddTest
    {
        
        //Addition
        [Test]
        public void AddTest1()
        {
            double result = Calc.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void AddTest2()
        {
            double result = Calc.Add(5.53, 3);
            Assert.IsNotNull(result);
        }
        [Test]
        public void AddTest3()
        {
            double result = Calc.Add(5.53, 3);
            double result1 = Calc.Add(5.53, 3);
            Assert.AreEqual(result, result1);
        }
        [Test]
        public void AddTest4()
        {
            Assert.IsNaN(Calc.Add(Double.NaN, 666));
        }
    }
}
