using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleNameSpace;

namespace TriangleNameSpace.UnitTests
{
    [TestClass]
    public class TriangleUnitTests
    {
        [TestMethod]
        public void IsTriangle_TwoSidesSumLessThenThird_false()
        {
            Assert.AreEqual(false, Triangle.IsTriangle(4, 2, 7));
        }

        [TestMethod]
        public void IsTriangle_GetsIntAndBoolValues_true()
        {
            Assert.AreEqual(true, Triangle.IsTriangle(4, 3.3f, 7));
        }

        [TestMethod]
        public void IsTriangle_HasZeroSide_false()
        {
            Assert.AreEqual(false, Triangle.IsTriangle(0, 3, 4));
        }

        [TestMethod()]
        public void IsTriangle_HasNegativeSide_false()
        {
            Assert.AreEqual(false, Triangle.IsTriangle(7, 3, -1));
        }

        [TestMethod()]
        public void IsTriangle_TwoSidesSumEqualesThird_false()
        {
            Assert.AreEqual(false, Triangle.IsTriangle(7, 3, 4));
        }

        [TestMethod()]
        public void IsTriangle_HasPositiveValuesAndSumOfEachTwoMoreThanThird_true()
        {
            Assert.AreEqual(true, Triangle.IsTriangle(7, 4, 4));
        }

        [TestMethod()]
        public void IsTriangle_IsEqualSided_true()
        {
            Assert.AreEqual(true, Triangle.IsEqualsided(4, 4, 4));
        }

        [TestMethod()]
        public void IsTriangle_IsRightAngled_true()
        {
            Assert.AreEqual(true, Triangle.IsRightAngled(3, 4, 5));
        }

        [TestMethod()]
        public void IsTriangle_IsRightAngledConsistingZeroValue_false()
        {
            Assert.AreEqual(false, Triangle.IsRightAngled(3, 0, 5));
        }

        [TestMethod()]
        public void IsTriangle_AllSidesEqualsZero_false()
        {
            Assert.AreEqual(false, Triangle.IsTriangle(0, 0, 0));
        }
    }
}
