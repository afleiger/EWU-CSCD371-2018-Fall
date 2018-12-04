using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace DataAnalyzer.Tests
{
    [TestClass]
    public class PatentDataAnalyzerTests
    {
        [TestMethod]
        public void InventorNames_QueryForUK_GetProperResultSuccess()
        {
            List<string> list = PatentDataAnalyzer.InventorNames("UK");

            Assert.AreEqual("George Stephenson", list[0]);
        }

        [TestMethod]
        public void InventorLastNames_CallMethod_GetListOfLastNamesSortedCorrectly()
        {
            List<string> lastNames = PatentDataAnalyzer.InventorLastNames();

            Assert.AreEqual("Jacob", lastNames[0]);
            Assert.AreEqual("Franklin", lastNames[6]);
        }

        [TestMethod]
        public void LocationsWithInventors_CallMethod_Success()
        {
            string locations = PatentDataAnalyzer.LocationsWithInventors();

            Assert.AreEqual("PA-USA,NC-USA,NY-USA,Northumberland-UK,IL-USA", locations);
        }

        [TestMethod]
        public void Randomize_CreateThreeRandomizedLists_ListIsNotSequenceEqual()
        {
            List<string> list = PatentDataAnalyzer.InventorLastNames().ToList();
            List<string> randomizedList = list.Randomize().ToList();
            List<string> randomizedList2 = list.Randomize().ToList();
            List<string> randomizedList3 = list.Randomize().ToList();

            Assert.IsFalse(list.SequenceEqual(randomizedList));
            Assert.IsFalse(list.SequenceEqual(randomizedList2));
            Assert.IsFalse(list.SequenceEqual(randomizedList3));
        }
    }
}
