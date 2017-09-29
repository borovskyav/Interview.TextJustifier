using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextJustifier.Core;

namespace TextJustifier.Tests
{
    [TestClass]
    public class JustifierTests
    {
        [TestInitialize]
        public void SetUp()
        {
            Justifier = new Justifier();
        }

        [TestMethod]
        public void TestSimpleUsage()
        {
            Assert.AreEqual("a b c d e", Justifier.Justify("a b c d e", 9));
            Assert.AreEqual("I play games", Justifier.Justify("I play games", 12));
            Assert.AreEqual("I came here to see you", Justifier.Justify("I came here to see you", 22));
            Assert.AreEqual("Java was invented by Sun", Justifier.Justify("Java was invented by Sun", 24));
        }

        [TestMethod]
        public void TestOneWord()
        {
            Assert.AreEqual("I        ", Justifier.Justify("I", 9));
            Assert.AreEqual("Like  ", Justifier.Justify("Like", 6));
            Assert.AreEqual("CSharp", Justifier.Justify("CSharp", 6));
        }

        [TestMethod]
        public void TestSameNumberOfSpaces()
        {
            Assert.AreEqual("a  b  c", Justifier.Justify("a b c", 7));
            Assert.AreEqual("a   b   c", Justifier.Justify("a b c", 9));
            Assert.AreEqual("I  play  games", Justifier.Justify("I play games", 14));
        }

        [TestMethod]
        public void TestDifferentNumberOfSpaces()
        {
            Assert.AreEqual("a  b c", Justifier.Justify("a b c", 6));
            Assert.AreEqual("I   play  games", Justifier.Justify("I play games", 15));
            Assert.AreEqual("I   do   not  play", Justifier.Justify("I do not play", 18));
        }

        private Justifier Justifier { get; set; }
    }
}