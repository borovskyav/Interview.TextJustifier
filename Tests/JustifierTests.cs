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
        public void Test()
        {
            Assert.AreEqual(Justifier.Justify("a b c", 5), "a b c");
        }

        private Justifier Justifier { get; set; }
    }
}