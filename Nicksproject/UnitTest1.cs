using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Nicksproject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 5;
            int y = 8;
            if (x > y)
            {
                Console.WriteLine('x');
            }
            else
            {
                Console.WriteLine('y');
            }
        }
    }
}
