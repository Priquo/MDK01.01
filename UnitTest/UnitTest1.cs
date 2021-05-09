using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Общий;
using System.Collections;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Top10Quadr a = new Top10Quadr();
        [TestMethod]
        public void TestMax()
        {
            //Assert.AreEqual(100, a.Max());
            //Assert.AreEqual(20, a.Max());
            Assert.AreEqual(10, a.Max());
        }
        [TestMethod]
        public void TestSort()
        {
            int[] sort = new int[10] { 100, 81, 64, 49, 36, 25, 16, 9, 4, 1 };
            //int[] sort = new int[10] { 100, 81, 64, 49, 36, 25, 6, 9, 4, 1 };
            //int[] sort = new int[10] { 100, 81, 64, 49, 36, 25, 16, 9, 4, 0 };
            int[] fact = a.Sort();
            Assert.IsTrue(sort.SequenceEqual(fact));
        }
    }
}
