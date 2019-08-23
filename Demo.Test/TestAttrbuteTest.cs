using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Test
{
    public class TestAttrbuteTest
    {
        /// <summary>
        /// 添加说明内容，等同于DescriptionAttribute属性
        /// </summary>
        //[Test(Description = "这是说明内容")]
        [Test, Description("这是说明属性")]
        public void Add()
        {
            Assert.AreEqual(4, 2 + 2);
        }

        // 标记异步方法
        [Test]
        public async Task AddAsync()
        {
            /* ... */
        }

        // 如果测试方法有返回值，要使用ExpectedResult校验
        [Test(ExpectedResult = 4)]
        public int TestAdd()
        {
            return 2 + 2;
        }

        // 异步含返回值的测试方法
        [Test(ExpectedResult = 4)]
        public async Task<int> TestAddAsync()
        {
            //await do something;
            return 2 + 2;
        }
    }
}
