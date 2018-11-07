using Microsoft.VisualStudio.TestTools.UnitTesting;
using src;

namespace Calendar.Tests
{
    [TestClass]
    public class ClassAndStructTests
    {
        [TestMethod]
        public void TestStruct_PassStructIntoMethod_DoesntChangeValue()
        {
            int myValue = 42;

            TestStruct myStruct = new TestStruct(myValue);

            SubtractFortyTwo(myStruct);

            Assert.AreEqual(myValue, myStruct.Value);
        }

        [TestMethod]
        public void TestClass_PassClassIntoMethod_ChangedValue()
        {
            TestClass myClass = new TestClass(42);

            SubtractFortyTwo(myClass);

            Assert.AreEqual(0, myClass.Value);
        }

        [TestMethod]
        public void TestStruct_PassToMethodByRef_ChangedValue()
        {
            IValued myStruct = new TestStruct(42);

            AddFortyTwo( ref myStruct);

            Assert.AreEqual(84, myStruct.Value);
        }

        [TestMethod]
        public void TestClass_PassToMethodCreateNewInstance_ChangedValue()
        {
            TestClass myClass = new TestClass(42);
            ReplaceClass(ref myClass);

            Assert.AreEqual(20, myClass.Value);
        }

        [TestMethod]
        public void TestStruct_CastStructToInterface_PassToMethod_ValueChanged()
        {
            TestStruct myStruct = new TestStruct(42);
            IValued myInterface = myStruct;

            SubtractFortyTwo(myInterface);

            Assert.AreEqual(0, myInterface.Value);
        }
         
        private void ReplaceClass(ref TestClass val)
        {
            val = new TestClass(20);
        }

        private void SubtractFortyTwo(IValued val)
        {
            val.Value -= 42;
        }

        private void AddFortyTwo( ref IValued val)
        {
            val.Value += 42;
        }
    }
}
