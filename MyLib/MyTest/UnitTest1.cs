using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MyLib.MyLinkedList<int> list = new MyLib.MyLinkedList<int>();

            list.Push(0);
            list.Push(-2);
            list.Push(34);
            list.Push(3);
            list.Push(17);

            Assert.AreEqual(list.Size(), 5);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MyLib.MyLinkedList<int> list = new MyLib.MyLinkedList<int>();

            list.Push(0);
            list.Push(-2);
            list.Push(34);
            list.Push(3);
            list.Push(17);

            int result = list.Pop();
            Assert.AreEqual(17, result);
            Assert.AreEqual(4, list.Size());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestMethod3()
        {
            MyLib.MyLinkedList<int> list = new MyLib.MyLinkedList<int>();
            list.Pop();
        }

        [TestMethod]
        public void TestMethod4()
        {
            MyLib.MyLinkedList<int> list = new MyLib.MyLinkedList<int>();
            list.Push(-111);
            Assert.AreEqual(1, list.Size());
            list.Pop();
            Assert.AreEqual(0, list.Size());
        }
    }
}
