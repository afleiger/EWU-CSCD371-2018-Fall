using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniversityWork.Tests
{
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void InstantiationTest_CreateManyCourseInstances_ReturnsCorrectCount()
        {
            Course course1 = new Course("101", "CSCD210", "CEB224", "Chris.Peters", 9);

            Assert.AreEqual(Course.InstanceCount, 1);

            Course course2 = new Course("240", "Math142", "Kingston 321", "Inigo.Montoya", 11);

            Assert.AreEqual(Course.InstanceCount, 2);

            Course course3 = new Course("555", "ART100", "ArtB506", "Bob.Ross", 4);

            Assert.AreEqual(Course.InstanceCount, 3);
        }
    }
}
