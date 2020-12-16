using NUnit.Framework;

namespace MyMath.Tests
{
    /// <summary>Represents TestClass for the Operations class.</summary>
    [TestFixture]
    public class OpTests
    {
        /// <summary>Test the method Add of the Operations class.</summary>
        [Test]
        [TestCase(-1, 23)]
        [TestCase(10000, 9999)]
        [TestCase(-24, -24)]
        [TestCase(0, 0)]
        public void When_PassingTwoParams_ReturnsTheSum(int a, int b)
        {
            int result = Operations.Add(a, b);
            Assert.AreEqual(a + b, result);
        }
    }
}