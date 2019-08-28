using System;
using System.Collections.Generic;
using System.Text;

namespace JustMockUnitTestSample.RaiseTest
{
    public delegate void CustomEvent(string value);

    public interface IFoo
    {
        event CustomEvent CustomEvent;
    }
}
