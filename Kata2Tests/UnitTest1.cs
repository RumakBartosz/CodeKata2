using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata2.binaryChops;

namespace Kata2Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestWholeIterativeBinarySearch()
        {
            IterativeBinaryChop IterativeMockClass = new IterativeBinaryChop();

            int[] emptyarray = { };
            Assert.AreEqual(-1, IterativeMockClass.Chop(3, emptyarray));

            int[] oneelementarrayTest = { 1 };
            Assert.AreEqual(-1, IterativeMockClass.Chop(3, oneelementarrayTest));
            Assert.AreEqual(0, IterativeMockClass.Chop(1, oneelementarrayTest));

            int[] threeElementArrayTest = { 1, 3, 5 };
            Assert.AreEqual(0, IterativeMockClass.Chop(1, threeElementArrayTest));
            Assert.AreEqual(1, IterativeMockClass.Chop(3, threeElementArrayTest));
            Assert.AreEqual(2, IterativeMockClass.Chop(5, threeElementArrayTest));
            Assert.AreEqual(-1, IterativeMockClass.Chop(0, threeElementArrayTest));
            Assert.AreEqual(-1, IterativeMockClass.Chop(2, threeElementArrayTest));
            Assert.AreEqual(-1, IterativeMockClass.Chop(4, threeElementArrayTest));
            Assert.AreEqual(-1, IterativeMockClass.Chop(6, threeElementArrayTest));

            int[] fourElementArrayTest = { 1, 3, 5, 7 };
            Assert.AreEqual(0, IterativeMockClass.Chop(1, fourElementArrayTest));
            Assert.AreEqual(1, IterativeMockClass.Chop(3, fourElementArrayTest));
            Assert.AreEqual(2, IterativeMockClass.Chop(5, fourElementArrayTest));
            Assert.AreEqual(3, IterativeMockClass.Chop(7, fourElementArrayTest));
            Assert.AreEqual(-1, IterativeMockClass.Chop(0, fourElementArrayTest));
            Assert.AreEqual(-1, IterativeMockClass.Chop(2, fourElementArrayTest));
            Assert.AreEqual(-1, IterativeMockClass.Chop(4, fourElementArrayTest));
            Assert.AreEqual(-1, IterativeMockClass.Chop(6, fourElementArrayTest));
            Assert.AreEqual(-1, IterativeMockClass.Chop(8, fourElementArrayTest));
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestWholeReccurentialBinarySearch()
        {
            RecursiveBinaryChop RecursiveMockClass = new RecursiveBinaryChop();

            int[] emptyarray = { };
            Assert.AreEqual(-1, RecursiveMockClass.Chop(3, emptyarray, 0, emptyarray.Length - 1));

            int[] oneelementarrayTest = { 1 };
            Assert.AreEqual(-1, RecursiveMockClass.Chop(3, oneelementarrayTest, 0, oneelementarrayTest.Length - 1));
            Assert.AreEqual(0, RecursiveMockClass.Chop(1, oneelementarrayTest, 0, oneelementarrayTest.Length - 1));

            int[] threeElementArrayTest = { 1, 3, 5 };
            Assert.AreEqual(0, RecursiveMockClass.Chop(1, threeElementArrayTest, 0, threeElementArrayTest.Length - 1));
            Assert.AreEqual(1, RecursiveMockClass.Chop(3, threeElementArrayTest, 0, threeElementArrayTest.Length - 1));
            Assert.AreEqual(2, RecursiveMockClass.Chop(5, threeElementArrayTest, 0, threeElementArrayTest.Length - 1));
            Assert.AreEqual(-1, RecursiveMockClass.Chop(0, threeElementArrayTest, 0, threeElementArrayTest.Length - 1));
            Assert.AreEqual(-1, RecursiveMockClass.Chop(2, threeElementArrayTest, 0, threeElementArrayTest.Length - 1));
            Assert.AreEqual(-1, RecursiveMockClass.Chop(4, threeElementArrayTest, 0, threeElementArrayTest.Length - 1));
            Assert.AreEqual(-1, RecursiveMockClass.Chop(6, threeElementArrayTest, 0, threeElementArrayTest.Length - 1));

            int[] fourElementArrayTest = { 1, 3, 5, 7 };
            Assert.AreEqual(0, RecursiveMockClass.Chop(1, fourElementArrayTest, 0, fourElementArrayTest.Length - 1));
            Assert.AreEqual(1, RecursiveMockClass.Chop(3, fourElementArrayTest, 0, fourElementArrayTest.Length - 1));
            Assert.AreEqual(2, RecursiveMockClass.Chop(5, fourElementArrayTest, 0, fourElementArrayTest.Length - 1));
            Assert.AreEqual(3, RecursiveMockClass.Chop(7, fourElementArrayTest, 0, fourElementArrayTest.Length - 1));
            Assert.AreEqual(-1, RecursiveMockClass.Chop(0, fourElementArrayTest, 0, fourElementArrayTest.Length - 1));
            Assert.AreEqual(-1, RecursiveMockClass.Chop(2, fourElementArrayTest, 0, fourElementArrayTest.Length - 1));
            Assert.AreEqual(-1, RecursiveMockClass.Chop(4, fourElementArrayTest, 0, fourElementArrayTest.Length - 1));
            Assert.AreEqual(-1, RecursiveMockClass.Chop(6, fourElementArrayTest, 0, fourElementArrayTest.Length - 1));
            Assert.AreEqual(-1, RecursiveMockClass.Chop(8, fourElementArrayTest, 0, fourElementArrayTest.Length - 1));
        }
    }

    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestWholeExponentialBinarySearch()
        {
            ExponentialBinaryChop ExponentialMockClass = new ExponentialBinaryChop();

            int[] emptyarray = { };
            Assert.AreEqual(-1, ExponentialMockClass.Chop(3, emptyarray, emptyarray.Length));

            int[] oneelementarrayTest = { 1 };
            Assert.AreEqual(-1, ExponentialMockClass.Chop(3, oneelementarrayTest, oneelementarrayTest.Length));
            Assert.AreEqual(0, ExponentialMockClass.Chop(1, oneelementarrayTest, oneelementarrayTest.Length));

            int[] threeElementArrayTest = { 1, 3, 5 };
            Assert.AreEqual(0, ExponentialMockClass.Chop(1, threeElementArrayTest, threeElementArrayTest.Length));
            Assert.AreEqual(1, ExponentialMockClass.Chop(3, threeElementArrayTest, threeElementArrayTest.Length));
            Assert.AreEqual(2, ExponentialMockClass.Chop(5, threeElementArrayTest, threeElementArrayTest.Length));
            Assert.AreEqual(-1, ExponentialMockClass.Chop(0, threeElementArrayTest, threeElementArrayTest.Length));
            Assert.AreEqual(-1, ExponentialMockClass.Chop(2, threeElementArrayTest, threeElementArrayTest.Length));
            Assert.AreEqual(-1, ExponentialMockClass.Chop(4, threeElementArrayTest, threeElementArrayTest.Length));
            Assert.AreEqual(-1, ExponentialMockClass.Chop(6, threeElementArrayTest, threeElementArrayTest.Length));

            int[] fourElementArrayTest = { 1, 3, 5, 7 };
            Assert.AreEqual(0, ExponentialMockClass.Chop(1, fourElementArrayTest, fourElementArrayTest.Length));
            Assert.AreEqual(1, ExponentialMockClass.Chop(3, fourElementArrayTest, fourElementArrayTest.Length));
            Assert.AreEqual(2, ExponentialMockClass.Chop(5, fourElementArrayTest, fourElementArrayTest.Length));
            Assert.AreEqual(3, ExponentialMockClass.Chop(7, fourElementArrayTest, fourElementArrayTest.Length));
            Assert.AreEqual(-1, ExponentialMockClass.Chop(0, fourElementArrayTest, fourElementArrayTest.Length));
            Assert.AreEqual(-1, ExponentialMockClass.Chop(2, fourElementArrayTest, fourElementArrayTest.Length));
            Assert.AreEqual(-1, ExponentialMockClass.Chop(4, fourElementArrayTest, fourElementArrayTest.Length));
            Assert.AreEqual(-1, ExponentialMockClass.Chop(6, fourElementArrayTest, fourElementArrayTest.Length));
            Assert.AreEqual(-1, ExponentialMockClass.Chop(8, fourElementArrayTest, fourElementArrayTest.Length));
        }
    }


    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestWholeInterpolationBinarySearch()
        {
            InterpolationBinaryChop InterpolationMockClass = new InterpolationBinaryChop();

            int[] emptyarray = { };
            Assert.AreEqual(-1, InterpolationMockClass.Chop(3, emptyarray, emptyarray.Length));

            int[] oneelementarrayTest = { 1 };
            Assert.AreEqual(-1, InterpolationMockClass.Chop(3, oneelementarrayTest, oneelementarrayTest.Length));
            Assert.AreEqual(0, InterpolationMockClass.Chop(1, oneelementarrayTest, oneelementarrayTest.Length));

            int[] threeElementArrayTest = { 1, 3, 5 };
            Assert.AreEqual(0, InterpolationMockClass.Chop(1, threeElementArrayTest, threeElementArrayTest.Length));
            Assert.AreEqual(1, InterpolationMockClass.Chop(3, threeElementArrayTest, threeElementArrayTest.Length));
            Assert.AreEqual(2, InterpolationMockClass.Chop(5, threeElementArrayTest, threeElementArrayTest.Length));
            Assert.AreEqual(-1, InterpolationMockClass.Chop(0, threeElementArrayTest, threeElementArrayTest.Length));
            Assert.AreEqual(-1, InterpolationMockClass.Chop(2, threeElementArrayTest, threeElementArrayTest.Length));
            Assert.AreEqual(-1, InterpolationMockClass.Chop(4, threeElementArrayTest, threeElementArrayTest.Length));
            Assert.AreEqual(-1, InterpolationMockClass.Chop(6, threeElementArrayTest, threeElementArrayTest.Length));

            int[] fourElementArrayTest = { 1, 3, 5, 7 };
            Assert.AreEqual(0, InterpolationMockClass.Chop(1, fourElementArrayTest, fourElementArrayTest.Length));
            Assert.AreEqual(1, InterpolationMockClass.Chop(3, fourElementArrayTest, fourElementArrayTest.Length));
            Assert.AreEqual(2, InterpolationMockClass.Chop(5, fourElementArrayTest, fourElementArrayTest.Length));
            Assert.AreEqual(3, InterpolationMockClass.Chop(7, fourElementArrayTest, fourElementArrayTest.Length));
            Assert.AreEqual(-1, InterpolationMockClass.Chop(0, fourElementArrayTest, fourElementArrayTest.Length));
            Assert.AreEqual(-1, InterpolationMockClass.Chop(2, fourElementArrayTest, fourElementArrayTest.Length));
            Assert.AreEqual(-1, InterpolationMockClass.Chop(4, fourElementArrayTest, fourElementArrayTest.Length));
            Assert.AreEqual(-1, InterpolationMockClass.Chop(6, fourElementArrayTest, fourElementArrayTest.Length));
            Assert.AreEqual(-1, InterpolationMockClass.Chop(8, fourElementArrayTest, fourElementArrayTest.Length));
        }
    }
}
