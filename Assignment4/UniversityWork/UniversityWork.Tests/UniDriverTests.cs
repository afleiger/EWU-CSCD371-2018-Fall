using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniversityWork.Tests
{
    [TestClass]
    public class UniDriverTests
    {
        [TestMethod]
        public void Display_PassSeveralObjectTypes_Success()
        {
            Course course = new Course("42", "JavaFx Gui Programming", "CEB 110", "Andrew.Fleiger", 8, "MWF", 2, 30);
            Event eve = new Event("10", "Dance Party", "My House", "Always");
            string str = "this is a boring string";

            Assert.IsTrue(0 < UniDriver.Display(course).Length);
            Assert.IsTrue(0 < UniDriver.Display(eve).Length);
            Assert.IsTrue(0 < UniDriver.Display(str).Length);
        }

        [TestMethod]
        public void DisplayCalendarItem_TestPolyMorphism_Success()
        {
            Course course = new Course("42", "JavaFx Gui Programming", "CEB 110", "Andrew.Fleiger", 8, "MWF", 2, 30);
            Event eve = new Event("10", "Dance Party", "My House", "Always");

            Assert.IsTrue(0 < UniDriver.DisplayCalendarItem(course).Length);
            Assert.IsTrue(0 < UniDriver.DisplayCalendarItem(eve).Length);
        }
    }
}
