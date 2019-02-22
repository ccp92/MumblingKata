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
    }
}