using System;
using kursach;
using NUnit.Framework;


namespace Tests
{
    [TestFixture]
    public class Class1
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void Test1()
        {
            HeapSort heap = new HeapSort();
            int[] massiv = new int[] { 6, 1 };
            int[] expected = new int[] { 1, 6 };
            int[] actual = new int[2];
            heap.sort(massiv);
            for (int i = 0; i < massiv.Length; i++)
            {
                actual[i] = massiv[i];
            }
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Register()
        {

        }
    }
}