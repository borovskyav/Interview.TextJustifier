using NUnit.Framework;
using TextJustifier.Core;

namespace TextJustifier.Tests
{
    [TestFixture]
    public class JustifierTests
    {
        [SetUp]
        public void SetUp()
        {
            Justifier = new Justifier();
        }

        [Test]
        public void TestSimpleUsage()
        {
            Assert.AreEqual(Justifier.Justify("a b c d e", 9), "a b c d e");
            Assert.AreEqual(Justifier.Justify("I play games", 12), "I play games");
            Assert.AreEqual(Justifier.Justify("I came here to see you", 22), "I came here to see you");
            Assert.AreEqual(Justifier.Justify("Java was invented by Sun", 24), "Java was invented by Sun");
        }

        [Test]
        public void TestOneWord()
        {
            Assert.AreEqual(Justifier.Justify("I", 9), "I        ");
            Assert.AreEqual(Justifier.Justify("Like", 6), "Like  ");
            Assert.AreEqual(Justifier.Justify("CSharp", 6), "CSharp");
        }

        [Test]
        public void TestSameNumberOfSpaces()
        {
            Assert.AreEqual(Justifier.Justify("a b c", 7), "a  b  c");
            Assert.AreEqual(Justifier.Justify("a b c", 9), "a   b   c");
            Assert.AreEqual(Justifier.Justify("I play games", 14), "I  play  games");
        }

        [Test]
        public void TestDifferentNumberOfSpaces()
        {
            Assert.AreEqual(Justifier.Justify("a b c", 6), "a  b c");
            Assert.AreEqual(Justifier.Justify("I play games", 15), "I   play  games");
            Assert.AreEqual(Justifier.Justify("I do not play", 17), "I   do  not  play");
        }

        private Justifier Justifier { get; set; }
    }
}