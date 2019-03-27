using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PassTest()
        {
            Assert.Pass();
        }

        [Test]
        public void SecondTest()
        {
            Assert.Fail();
        }
    }
}