using System;
using System.Collections.Generic;
using System.Text;

namespace JustMockUnitTestSample.InternalTest
{
    public class FooInternalCtor
    {
        internal FooInternalCtor(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }

        private string name;
    }
}
