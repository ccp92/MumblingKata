using Microsoft.VisualStudio.TestPlatform.Common.Utilities;
using Mumbling;
using NUnit.Framework;

namespace MumblingTests
{
    public class Tests
    {
        private readonly Mumble _mumble = new Mumble();

        [TestFixture]
        public class GivenAnEmptyString
        {
            [Test]
            public void ReturnsAnEmptyString()
            {
                Assert.AreEqual("", Mumble.Execute(""));
            }
        }
        
        [TestFixture]
        public class GivenASingleCharacterString
        {
            [Test]
            public void ReturnsTheSameCapitalisedString()
            {
                Assert.AreEqual("A", Mumble.Execute("A"));
            }
        
            [Test]
            public void ReturnsACapitalisedString()
            {
                Assert.AreEqual("A", Mumble.Execute("a"));
            }  
        }

        [TestFixture]
        public class GivenAStringWith2Characters
        {
            [Test]
            public void ReturnsAMumbledString()
            {
                Assert.AreEqual("ABb", Mumble.Execute("ab"));
            }
        }
    }
}