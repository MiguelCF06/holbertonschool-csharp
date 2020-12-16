using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void IsPalindrome_When_PassingAnEmptyString_ReturnsTrue()
        {
            string s = string.Empty;
            bool result = Text.Str.IsPalindrome(s);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsPalindrome_WhenPassingStringWithUpperAndLowerCase_ReturnsTrue()
        {
            string s = "Civic";
            bool result = Text.Str.IsPalindrome(s);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsPalindrome_WhenPassingANotPalindromeString_ReturnsFalse()
        {
            string s = "Not Palindrome";
            bool result = Text.Str.IsPalindrome(s);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsPalindrome_WhenPassingStringWithPunctuation_ReturnsTrue()
        {
            string s = "A man, a plan, a canal: Panama.";
            bool result = Text.Str.IsPalindrome(s);
            Assert.AreEqual(true, result);
        }
    }
}