using System;
using System.Collections.Generic;
using System.Text;

namespace JustMockUnitTestSample.RaisesTest
{
    public delegate void CustomEvent(string value, bool called);

    public delegate void EchoEvent(bool echoed);

    public delegate void ExecuteEvent();

    public interface IFoo
    {
        event CustomEvent CustomEvent;
        event EchoEvent EchoEvent;
        event ExecuteEvent ExecuteEvent;

        void RaiseMethod();
        string Echo(string arg);
        void Execute();
        void Execute(string arg);
    }
}
