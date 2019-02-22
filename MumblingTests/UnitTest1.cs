using Microsoft.VisualStudio.TestPlatform.Common.Utilities;
using Mumbling;
using NUnit.Framework;

namespace MumblingTests
{
    public class Tests
    {
        private Mumble _mumble = new Mumble();

        [Test]
        public void ReturnsAnEmptyString()
        {
            Assert.AreEqual("", _mumble.Execute(""));
        }

        [Test]
        public void ReturnsTheSameCapitalisedString()
        {
            Assert.AreEqual("A", _mumble.Execute("A"));
        }
        
        [Test]
        public void ReturnsACapitalisedString()
        {
            Assert.AreEqual("A", _mumble.Execute("a"));
        }
    }
}