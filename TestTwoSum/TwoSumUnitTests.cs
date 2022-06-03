using NUnit.Framework;
using TwoSum;

namespace TestTwoSum
{
    public class TwoSumUnitTests
    {
        TwoSumClass _twoSum;  

        [SetUp]
        public void Setup()
        {
            _twoSum = new TwoSumClass();
        }

        [Test]
        public void TestTwoSum1()
        {
            var nums = new int[] {1, 2, 3, 4, 5};
            var target = 3;
            var expectedValues = new int[] { 0, 1 };
            CollectionAssert.AreEqual(expectedValues, _twoSum.CalculateTwoSum(nums, target));
        }

        [Test]
        public void TestTwoSum2()
        {
            var nums = new int[] { 1, 2, 3, 4, 5 , 7, 31, 21};
            var target = 22;
            var expectedValues = new int[] { 0, 7 };
            CollectionAssert.AreEqual(expectedValues, _twoSum.CalculateTwoSum(nums, target));
        }

        [Test]
        public void NeagtiveTestTwoSum()
        {
            var nums = new int[] { 1, 2, 3, 4 };
            var target = 8;
            var expectedValues = new int[] { 0, 0 };
            CollectionAssert.AreEqual(expectedValues, _twoSum.CalculateTwoSum(nums, target));
        }
    }
}