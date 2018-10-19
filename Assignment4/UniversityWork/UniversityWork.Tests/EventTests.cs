using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniversityWork.Tests
{
    [TestClass]
    public class EventTests
    {
        [TestMethod]
        public void InstantiationTest_CreateManyEventInstances_ReturnsCorrectCount()
        {
            Assert.AreEqual(Event.InstanceCount, 0);

            Event event1 = new Event("1", "Bon Fire", "Park", "Monday at 4pm");

            Assert.AreEqual(Event.InstanceCount, 1);
        }
    }

}
