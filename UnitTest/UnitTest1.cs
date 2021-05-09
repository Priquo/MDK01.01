using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Общий;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Top10Quadr a = new Top10Quadr();
        [TestMethod]
        public void TestMax()
        {
            Assert.AreEqual(100, a.Max());
        }
        [TestMethod]
        public void TestSort()
        {
            int[] sort = new int[10] { 100, 81, 64, 49, 36, 25, 16, 9, 4, 1 };
            int[] fact = a.Sort();
            for (int i = 1; i < 11; i++)
            {
                Assert.AreEqual(sort[i-1], fact[i-1]);
            }
        }
    }
}
