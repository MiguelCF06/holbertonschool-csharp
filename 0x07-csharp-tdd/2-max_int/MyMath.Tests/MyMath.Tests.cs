using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void When_PassingListNumsWithoutValues_ReturnZero()
        {
            List<int> nums = new List<int>();
            int result = Operations.Max(nums);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void When_PassingListNumsWithValues_ReturnTheMaxInteger()
        {
            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(23);
            nums.Add(24);
            nums.Add(2);
            nums.Add(22);
            nums.Add(-10);
            nums.Add(-26);
            int result = Operations.Max(nums);
            Assert.AreEqual(24, result);
        }

        [Test]
        public void When_PassingListNumsWithNegativeValues_ReturnTheMaxInteger()
        {
            List<int> nums = new List<int>();
            nums.Add(-1);
            nums.Add(-23);
            nums.Add(-24);
            nums.Add(-2);
            nums.Add(-22);
            nums.Add(-10);
            nums.Add(-26);
            int result = Operations.Max(nums);
            Assert.AreEqual(-1, result);
        }
    }
}