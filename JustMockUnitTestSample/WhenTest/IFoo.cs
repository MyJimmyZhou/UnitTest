using System;
using System.Collections.Generic;
using System.Text;

namespace JustMockUnitTestSample.WhenTest
{
    public interface IFoo
    {
        bool IsCalled();
        string Prop { get; set; }
    }
}
