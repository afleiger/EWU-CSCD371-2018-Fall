using Microsoft.VisualStudio.TestTools.UnitTesting;
using src;
using System;
using System.Runtime.InteropServices;

namespace Calendar.Tests
{
    [TestClass]
    public class ScheduleTests
    {
        [TestMethod]
        public void Time_InstantiateTimeWithInvalidValues_ValuesSetToZero()
        {
            Time myTime = new Time(30, 200, 100);

            Assert.AreEqual(0, myTime.Hour);
            Assert.AreEqual(0, myTime.Minute);
            Assert.AreEqual(0, myTime.Second);
        }

        [TestMethod]
        public void Time_InstantiateTime_Success()
        {
            Time myTime = new Time(2, 30, 15);

            Assert.AreEqual(2, myTime.Hour);
            Assert.AreEqual(30, myTime.Minute);
            Assert.AreEqual(15, myTime.Second);
        }

        [TestMethod]
        public void InitializeSchedule_HasProperValues_Success()
        {
            Time time = new Time(12, 30, 45);
            MySchedule mySchedule = new MySchedule(DaysOfWeek.Monday | DaysOfWeek.Friday, Quarters.Fall, time, TimeSpan.FromHours(1));

            Assert.AreEqual(DaysOfWeek.Monday | DaysOfWeek.Friday, mySchedule.Days);
            Assert.AreEqual(Quarters.Fall, mySchedule.Quarter);
        }

        [TestMethod]
        public void TestSizeOfSchedule_EqualTo16Bytes()
        {
            Time time = new Time(12, 30, 45);
            MySchedule mySchedule = new MySchedule(DaysOfWeek.Monday | DaysOfWeek.Friday, Quarters.Fall, time, TimeSpan.FromHours(1));

            Assert.AreEqual(16, Marshal.SizeOf(mySchedule));
        }

        [TestMethod]
        public void DaysOfWeek_UseBitwiseOperatorsToAddFlags_Success()
        {
            DaysOfWeek days = DaysOfWeek.Monday;
            days |= DaysOfWeek.Tuesday;

            Assert.AreEqual(DaysOfWeek.Monday | DaysOfWeek.Tuesday, days);
        }

        [TestMethod]
        public void DaysOfWeek_UseBitwiseNotToSetFlags_Success()
        {
            DaysOfWeek days = ~DaysOfWeek.Monday;

            Assert.IsTrue(days.HasFlag(DaysOfWeek.Tuesday) && days.HasFlag(DaysOfWeek.Thursday) && !days.HasFlag(DaysOfWeek.Monday));
        }

        [TestMethod]
        public void DaysOfWeek_ParseStringSettingMultipleFlags_Success()
        {
            DaysOfWeek days;
            Enum.TryParse("Monday,Friday", out days);

            Assert.IsTrue(days.HasFlag(DaysOfWeek.Monday) && days.HasFlag(DaysOfWeek.Friday));
            Assert.IsFalse(days.HasFlag(DaysOfWeek.Sunday));

        }

        [TestMethod]
        public void DaysOfWeek_ParseStringWithSingleFlag_Success()
        {
            DaysOfWeek days;
            Enum.TryParse("Saturday", out days);

            Assert.IsTrue(days.HasFlag(DaysOfWeek.Saturday));
            Assert.IsFalse(days.HasFlag(DaysOfWeek.Monday) || days.HasFlag(DaysOfWeek.Sunday) || days.HasFlag(DaysOfWeek.Wednesday));
        }

        [TestMethod]
        public void Quarters_ParseStringWithMultipleFlags_Success()
        {
            Quarters quarters;
            Enum.TryParse("Spring, Summer", out quarters);

            Assert.IsTrue(quarters.HasFlag(Quarters.Spring) && quarters.HasFlag(Quarters.Summer));
            Assert.IsFalse(quarters.HasFlag(Quarters.Fall) || quarters.HasFlag(Quarters.Winter));
        }

        [TestMethod]
        public void Quarters_ParseStringWithSingleFlag_Success()
        {
            Quarters quarters;
            Enum.TryParse("Winter", out quarters);

            Assert.IsTrue(quarters.HasFlag(Quarters.Winter) && !quarters.HasFlag(Quarters.Spring) && !quarters.HasFlag(Quarters.Fall));
        }
    }
}
