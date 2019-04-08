using NUnit.Framework;
using System.Threading;

namespace Tests
{
    [Category("Unit_Tests")]
    [Property("Priority", 2)]
    public class BarTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1100)]
        [TestCase(5000)]
        public void BarTest1(int testCase)
        {
            Thread.Sleep(testCase);
            Assert.Pass();
        }
    }
}