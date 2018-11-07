using Microsoft.VisualStudio.TestTools.UnitTesting;
using src;

namespace Calendar.Tests
{
    [TestClass]
    public class CalendarTests
    {
        [TestMethod]
        public void DaysOfWeek_AbleToParse()
        {
            DaysOfWeek ClassDays = DaysOfWeek.Monday | DaysOfWeek.Tuesday| DaysOfWeek.Sunday;


            Assert.AreEqual(true, ClassDays.HasFlag(DaysOfWeek.Monday));
            Assert.AreEqual(true, ClassDays.HasFlag(DaysOfWeek.Tuesday));
            Assert.AreEqual(true, ClassDays.HasFlag(DaysOfWeek.Sunday));
        }
    }
}
