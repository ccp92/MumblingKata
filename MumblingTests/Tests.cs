using Microsoft.VisualStudio.TestPlatform.Common.Utilities;
using Mumbling;
using NUnit.Framework;

namespace MumblingTests
{
    public class Tests
    {
        private readonly Mumble _mumble = new Mumble();

        public class GivenAnEmptyString
        {
            [Test]
            public void ReturnsAnEmptyString()
            {
                Assert.AreEqual("", Mumble.Execute(""));
            }
        }

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
    }
}