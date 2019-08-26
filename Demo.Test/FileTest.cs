using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Demo.Test
{
    public class FileTest
    {
        [Test]
        public void File_Test()
        {
            string file = AppDomain.CurrentDomain.BaseDirectory + "/Directory/file.txt";
            // 判断文件是否存在
            FileAssert.Exists(file);
            FileInfo fileInfo = new FileInfo(file);
            FileInfo fileInfo2 = new FileInfo(file);
            FileAssert.AreEqual(fileInfo, fileInfo2);
        }
    }
}
