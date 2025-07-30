using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemos.Tests
{
    [TestFixture]
    public class DemoTest
    {
        public void TestSum()
        {
            Demo demo = new Demo();
            Assert.AreEqual(5, demo.Sum(2, 3));
        }
        [Test]
        public void TestSayHello()
        {
            Demo demo = new Demo();
            Assert.AreEqual("Welcome to C# FSD Programming...", demo.SayHello());

                

        }
        [Test]
        public void TestNullCheck()
        {
            Demo demo = new Demo();
            Assert.IsNotNull(demo);
            Demo demo1 = null;  
            Assert.IsNull(demo1);
        }
        [Test]
        public void TestMax3()
        {
            Demo demo = new Demo();
            Assert.AreEqual(3, demo.Max3(7, 3, 2));
            Assert.AreEqual(7, demo.Max3(3, 7, 2));
        } 
        
    }
}
