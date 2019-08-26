using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Test
{
    public class DirectoryTest
    {
        [Test]
        public void Directory_Test()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryAssert.Exists(basePath + "/Directory"); // 判断文件夹是否存在
        }
    }

}
