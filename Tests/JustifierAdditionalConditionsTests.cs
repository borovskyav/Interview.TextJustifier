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
            Assert.Throws<ArgumentException>(() => Justifier.Justify("CSharp is a programming language", 10));
        }

        [Test]
        public void TestNewlines()
        {
            Assert.AreEqual("I  don't  like\nblack   coffee", Justifier.Justify("I don't like black coffee", 14));
            Assert.AreEqual("a  b\nc  d", Justifier.Justify("a b c d", 4));
            Assert.AreEqual("She   does\nnot   play", Justifier.Justify("She does not play", 10));
        }

        [Test]
        public void TestOneWordInNewlines()
        {
            Assert.AreEqual("I   play\ngames   ", Justifier.Justify("I play games", 8));
            Assert.AreEqual("I     am\nplaying \na   game", Justifier.Justify("I am playing a game", 8));
        }

        private Justifier Justifier { get; set; }
    }
}