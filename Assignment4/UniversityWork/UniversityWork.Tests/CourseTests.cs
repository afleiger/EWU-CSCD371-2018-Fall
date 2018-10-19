using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniversityWork.Tests
{
    [TestClass]
    public class CourseTests
    {
        private Course Course;

        [TestInitialize]
        public void Test_Initialize()
        {
            Course = new Course("42", "Math101", "Kingston 333", "Inigo.Montoya", 9, "MTWThF", 1, 25);

            Course.InstanceCount = 0;
        }

        [TestMethod]
        public void BaseClassDeconstructor_CallBaseClassDeconstructor_Success()
        {
            (string id, string title, string location) = Course;

            Assert.AreEqual(id, "42");
            Assert.AreEqual(title, "Math101");
            Assert.AreEqual(location, "Kingston 333");
        }

        [TestMethod]
        public void Deconstructor_CallDeconconstructorCheckValues_Success()
        {
            (string id, string title, string location, string professorName, int startHour, string classDays, int classLength, int studentCount) = Course;

            Assert.AreEqual("42", id);
            Assert.AreEqual("Math101", title);
            Assert.AreEqual("Kingston 333", location);
            Assert.AreEqual(9, startHour);
            Assert.AreEqual("MTWThF", classDays);
            Assert.AreEqual(1, classLength);
            Assert.AreEqual(25, studentCount);
        }

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

        [TestMethod]
        public void EndTime_GetEndTimeCheckCalculation_Success()
        {
            Course course = new Course("CSCD9999", "Ultimate Coding", "CEB 500", "Inigo.Montoya", 11, "TTh", 2, 13);

            Assert.AreEqual(1, course.EndHour);
        }
    }
}
