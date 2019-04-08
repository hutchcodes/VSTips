using NUnit.Framework;

namespace Tests
{
    [Category("Unit_Tests")]
    [Property("Priority", 1)]
    public class FooTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FooTest1()
        {
            Assert.Pass();
        }
    }
}