using System;
using System.Collections.Generic;
using System.Text;

namespace JustMockUnitTestSample.SequentialMock
{
    public interface IFoo
    {
        string Execute(string arg);
        int Echo(int arg1);
        int GetIntValue();
    }
}
