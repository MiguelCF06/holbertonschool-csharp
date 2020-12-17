using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CamelCase_WhenPassingANullString_ReturnsZero()
        {
            string s = null;
            int words = Str.CamelCase(s);
            Assert.AreEqual(0, words);
        }

        [Test]
        public void CamelCase_WhenPassingAnEmptyString_ReturnsZero()
        {
            string s = "";
            int words = Str.CamelCase(s);
            Assert.AreEqual(0, words);
        }

        [Test]
        public void CamelCase_WhenPassingAString_ReturnsNumberOfWords()
        {
            string s = "justBeYourself";
            int words = Str.CamelCase(s);
            Assert.AreEqual(3, words);
        }
    }
}