using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JustMockUnitTestSample.ThrowsTest
{
    public class Foo
    {
        public async Task AsyncExecute()
        {
            await Task.Delay(1000);
        }
    }
}
