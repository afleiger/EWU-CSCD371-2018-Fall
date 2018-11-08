using Microsoft.VisualStudio.TestTools.UnitTesting;
using src;

namespace Generics.Tests
{
    [TestClass]
    public class InstanceCounterTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, InstanceCounter.InstanceCount);

            InstanceCounter ic = new InstanceCounter();

            Assert.AreEqual(1, InstanceCounter.InstanceCount);

            ic = null;
            foo();
        }


        public void foo()
        {

            Assert.AreEqual(0, InstanceCounter.InstanceCount);

        }
    }
}
