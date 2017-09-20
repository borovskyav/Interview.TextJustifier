using System;
using NUnit.Framework;
using TextJustifier.Core;

namespace TextJustifier.Tests
{
    public class JustifierAdditionalConditionsTests
    {
        [SetUp]
        public void SetUp()
        {
            Justifier = new Justifier();
        }

        [Test]
        public void TestWordsLongerThanGivenLength()
        {
            Assert.Throws<ArgumentException>(() => Justifier.Justify("Hello", 4));
            Assert.Throws<ArgumentException>(() => Justifier.Justify("CSharp is programming language", 10));
        }

        [Test]
        public void TestNewlines()
        {
            Assert.AreEqual(Justifier.Justify("I don't like black coffee", 14), "I  don't  like/nblack   coffee");
            Assert.AreEqual(Justifier.Justify("a b c d", 4), "a  b/nc  d");
            Assert.AreEqual(Justifier.Justify("I do not play", 8), "I     do/nnot play");
            Assert.AreEqual(Justifier.Justify("She does not play", 10), "She     do/nnot   play");
        }

        public void TestOneWordInNewlines()
        {
            Assert.AreEqual(Justifier.Justify("I play games", 8), "I   play/ngames   ");
            Assert.AreEqual(Justifier.Justify("aaa bbb cccccc ddd eee", 7), "aaa bbb/nccccc  /nddd  ee");
        }

        private Justifier Justifier { get; set; }
    }
}