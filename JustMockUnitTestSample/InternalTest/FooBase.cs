using System;
using System.Collections.Generic;
using System.Text;

namespace JustMockUnitTestSample.InternalTest
{
    public interface IManager
    {
        object Provider { get; }
    }

    public class FooBase : IManager
    {
        object IManager.Provider
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class Bar : FooBase
    {
    }
}
