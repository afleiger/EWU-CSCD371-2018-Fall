using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Course.Tests
{
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void Constructor_CreateCourse()
        {
            Course course1 = new Course(10, "Math101", "Professor", "X", "MTWThF", 9, 1, 25);
            Assert.AreEqual(course1.ID, 10);
        }
    }
}
