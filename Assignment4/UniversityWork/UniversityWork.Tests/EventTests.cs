using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniversityWork.Tests
{
    [TestClass]
    public class EventTests
    {
        private Event Event;

        [TestInitialize]
        public void Test_Initialize()
        {
            Event = new Event("42", "Groovy Shoes", "Spokane Arena", "7pm");
            Event.InstanceCount = 0;
        }

        [TestMethod]
        public void Deconstructor_CallDeconstructor_Success()
        {
            (string id, string title, string location, string time) = Event;

            Assert.AreEqual(id, "42");
            Assert.AreEqual(title, "Groovy Shoes");
            Assert.AreEqual(location, "Spokane Arena");
            Assert.AreEqual(time, "7pm");
        }

        [TestMethod]
        public void InstantiationTest_CreateManyEventInstances_ReturnsCorrectCount()
        {
            Assert.AreEqual(0, Event.InstanceCount);

            Event event1 = new Event("1", "Bon Fire", "Park", "Monday at 4pm");
            Assert.AreEqual(1, Event.InstanceCount);
        }
    }

}
