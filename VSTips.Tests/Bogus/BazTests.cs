using NUnit.Framework;
using System.Threading;

namespace Tests.Bogus
{
    [Category("Integration_Tests")]
    [Property("Priority", 2)]
    public class BazTests
    {
        [Test]
        public void BazTest1()
        {
            Thread.Sleep(200);
            Assert.Fail();
        }

        [Test]
        [Explicit]
        [Category("Useless_Tests")]
        [Category("Slow_Tests")]
        public void BazTest2()
        {
            Thread.Sleep(2000);
            Assert.Fail();
        }
    }
}