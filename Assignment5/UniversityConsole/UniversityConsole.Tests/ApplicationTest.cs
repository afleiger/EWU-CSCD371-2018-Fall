using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using IntelliTect.TestTools.Console;
using src;

namespace UniversityConsole.Tests
{
    [TestClass]
    public class ApplicationTest
    {
        private static readonly string newLine = Environment.NewLine;

        [TestMethod]
        public void DisplayMenu_CallMethod_Success()
        {
            IConsole testConsole = new TestConsole();
            Application.DisplayMenu(testConsole);

            Assert.AreEqual($"{newLine}     1: View Calendar{newLine}     2: Add Event{newLine}('q' to quit)----->", testConsole.LastWrittenLine);
        }

        [TestMethod]
        public void GetMenuInput_Input1_Returns1()
        {
            TestConsole testConsole = new TestConsole();
            testConsole.LineToRead = "1";

            string output = Application.GetMenuInput(testConsole);

            Assert.AreEqual("1", output);
        }

        [TestMethod]
        public void GetMenuInput_Input2_Returns2()
        {
            TestConsole testConsole = new TestConsole();
            testConsole.LineToRead = "2";

            string output = Application.GetMenuInput(testConsole);

            Assert.AreEqual("2", output);
        }

        [TestMethod]
        public void GetMenuInput_InputQ_ReturnsQ()
        {
            TestConsole testConsole = new TestConsole();
            testConsole.LineToRead = "q";

            string output = Application.GetMenuInput(testConsole);

            Assert.AreEqual("q", output);
        }

        [TestMethod]
        public void GetMenuInput_InvalidInput_Returns0()
        {
            TestConsole testConsole = new TestConsole();
            testConsole.LineToRead = "invalidInput";

            string output = Application.GetMenuInput(testConsole);

            Assert.AreEqual("0", output);
        }

        [TestMethod]
        public void DisplayEventList_CallMethod_Success()
        {
            TestConsole testConsole = new TestConsole();
            List<IEvent> eventList = new List<IEvent>();
            Event @event = new Event("42", "Movie Night", "My House", "5pm");
            eventList.Add(@event);

            Application.DisplayEventList(eventList, testConsole);

            Assert.AreEqual(@event.DisplayInformation(), testConsole.LastWrittenLine);
        }

        [TestMethod]
        public void CreateEvent_ValidInput_Success()
        {
            TestConsole testConsole = new TestConsole();
            testConsole.LineToRead = "42";

            IEvent @event = Application.CreateEvent(testConsole);

            Assert.AreEqual("42", @event.ID);
            Assert.AreEqual("42", @event.Title);
            Assert.AreEqual("42", @event.Location);
        }

        [TestMethod]
        public void InformationLength_TestExtensionMethod_Success()
        {
            IEvent @event = new Event("ID", "123", "456");

            Assert.AreEqual(6, @event.InformationLength());
        }

        [TestMethod]
        public void EventCasting_DirectCastToEvent_GetTimeInfo()
        {
            IEvent @event = new Event("42", "42", "42", "6pm");

            Assert.AreEqual("6pm", ((Event)@event).TimeInformation);
        }
    }
}