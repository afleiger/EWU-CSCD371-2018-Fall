using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
    public class TestClass : IValued
    {
        public int Value { get; set; }

        public TestClass(int value)
        {
            Value = value;
        }
    }
}
