using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
    public struct TestStruct : IValued
    {
        public int Value { get; set; }

        public TestStruct(int value)
        {
            Value = value;
        }
    }
}
