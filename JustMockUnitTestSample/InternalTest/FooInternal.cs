using System;
using System.Collections.Generic;
using System.Text;

namespace JustMockUnitTestSample.InternalTest
{
    internal class FooInternal
    {
        internal FooInternal()
        {
            builder = new StringBuilder();
        }

        public StringBuilder Builder
        {
            get
            {
                return builder;
            }
        }

        private StringBuilder builder;
    }
}
