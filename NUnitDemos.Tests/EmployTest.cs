using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitDemos.Tests
{
    [TestFixture]
    internal class EmployTest
    {
        [Test]
        public  void TestToString()
        {
            Employ employ = new Employ();
            employ.Empno = 1;
            employ.Name = "Baby";
            employ.Basic = 234355;

            string expected = "Empno1 Name: Baby Basic: 234355";
            Assert.AreEqual(expected, employ.ToString());
        }
        [Test]
        public void TestGetersAndSetters()
        {
            Employ employ = new Employ();
            employ.Empno = 1;
            employ.Name = "Baby";
            employ.Basic = 234355;

            Assert.AreEqual(10, employ.Empno);
            Assert.AreEqual("Baby", employ.Name);
            Assert.AreEqual(234355, employ.Basic);

        }
        [Test]
        public void TestConstructor()
        {
            Employ employ = new Employ();
            Assert.NotNull(employ);
            employ employ1 = new employ(22, "Baby", 234355);
            Assert.AreEqual(1, employ1.Empno);
            Assert.AreEqual("Baby", employ1.Name);
            Assert.AreEqual(234355, employ1.Basic);

        }
    }
}
