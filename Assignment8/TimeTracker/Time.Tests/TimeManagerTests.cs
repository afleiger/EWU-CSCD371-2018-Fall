using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimeTracker;

namespace Time.Tests
{
    [TestClass]
    public class TimeManagerTests
    {
        private string ChangeMe { get; set; }


        [TestMethod]
        public void TimeManager_GetSpanString_Success()
        {
            TimeManager tm = new TimeManager(new TestDateTime());

            Assert.AreEqual("43.18:42:42", tm.SpanString);
        }

        [TestMethod]
        public void TimeManager_GetNowString_Success()
        {
            TimeManager tm = new TimeManager(new TestDateTime());

            Assert.AreEqual("This is Now!", tm.NowString);
        }

        [TestMethod]
        public void TimeManager_ConnectEventHandler_StartAndStopTimer_EventHandlerIsTriggered()
        {
            TimeManager tm = new TimeManager(new TestDateTime());
            tm.UpdateEvent += TestTriggered;

            Assert.AreEqual("This is the Start!  ", tm.StartTimer());

            ChangeMe = "UnTouched";
            tm.EndTimer();

            Assert.AreEqual("Changed", ChangeMe);
        }

        private void TestTriggered(object o, TimeArgs e)
        {
            ChangeMe = "Changed";
        }
    }
}
