using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextJustifier.Core;

namespace TextJustifier.Tests
{
    [TestClass]
    public class JustifierAdditionalConditionsTests
    {
        private Justifier Justifier { get; set; }

        [TestInitialize]
        public void SetUp()
        {
            Justifier = new Justifier();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestWordsLongerThanGivenLength_1()
        {
            Justifier.Justify("Hello", 4);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestWordsLongerThanGivenLength_2()
        {
            Justifier.Justify("CSharp is a programming language", 10);
        }


        [TestMethod]
        public void TestNewlines()
        {
            Assert.AreEqual("I  don't  like\nblack   coffee", Justifier.Justify("I don't like black coffee", 14));
            Assert.AreEqual("a  b\nc  d", Justifier.Justify("a b c d", 4));
            Assert.AreEqual("She   does\nnot   play", Justifier.Justify("She does not play", 10));
        }

        [TestMethod]
        public void TestOneWordInNewlines()
        {
            Assert.AreEqual("I   play\ngames   ", Justifier.Justify("I play games", 8));
            Assert.AreEqual("I     am\nplaying \na   game", Justifier.Justify("I am playing a game", 8));
        }
    }
}