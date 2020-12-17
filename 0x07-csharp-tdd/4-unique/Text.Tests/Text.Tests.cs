using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Unique_WhenStringIsEmpty_ReturnsMinusOne()
        {
            string s = "";
            int index = Text.Str.UniqueChar(s);
            Assert.AreEqual(-1, index);
        }

        [Test]
        public void Unique_WhenPassingANullString_ReturnsMinusOne()
        {
            string s = null;
            int index = Text.Str.UniqueChar(s);
            Assert.AreEqual(-1, index);
        }

        [Test]
        public void Unique_WhenPassingAStringWithRepeatedChars_ReturnsMinusOne()
        {
            string s = "Hhhh";
            int index = Text.Str.UniqueChar(s);
            Assert.AreEqual(-1, index);
        }

        [Test]
        public void Unique_WhenPassingASingleChar_ReturnsIndex()
        {
            string s = "m";
            int index = Text.Str.UniqueChar(s);
            Assert.AreEqual(0, index);
        }

        [Test]
        public void Unique_WhenPassingAStringWithDifferentChars_ReturnIndex()
        {
            string s = "Hello my dear friend, how are you";
            int index = Text.Str.UniqueChar(s);
            Assert.AreEqual(6, index);
        }
    }
}