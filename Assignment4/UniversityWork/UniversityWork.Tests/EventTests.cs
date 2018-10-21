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
        public void SetTimeInformation_ChangeValue_Success()
        {
            Event.TimeInformation = "Next Week On Tuesday";

            Assert.AreEqual("Next Week On Tuesday", Event.TimeInformation);
        }

        [TestMethod]
        public void SetTitle_ChangeTitleValue_Success()
        {
            Event.Title = "Board Game Night";

            Assert.AreEqual("Board Game Night", Event.Title);
        }

        [TestMethod]
        public void SetId_ChangeIdValue_Success()
        {
            Event.ID = "424242";

            Assert.AreEqual("424242", Event.ID);
        }

        [TestMethod]
        public void SetLocation_ChangeLocationValue_Success()
        {
            Event.Location = "My House";

            Assert.AreEqual("My House", Event.Location);
        }

        [TestMethod]
        public void GetSummaryInformation_CallMethod_Success()
        {
            Assert.AreEqual(@"-------Event_Information-------
Id: 42        Title: Groovy Shoes      Location: Spokane Arena        Time: 7pm", Event.GetSummaryInformation());
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
