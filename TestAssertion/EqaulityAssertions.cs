using NUnit.Framework;
using System;
namespace TestAssertion
{
    [TestFixture]
    public class EqaulityAssertions
    {
        [Test]
        public void AreEqual()
        {
            Assert.AreEqual("expected", "actual");
        }
        [Test]
        public void AreEqualWithDescription()
        {
            Assert.AreEqual("expected", "what does this even mean");
        }

        [Test]
        public void AreEqualWithDynamicDescription()
        {
            Assert.AreEqual("expected", "actual","what does {0} mean to {1}", "testing", "you");
        }
        [Test]
        public void AreEqualNumbers()
        {
            Assert.AreEqual(1,2);
        }
        [Test]
        public void AreEqualNumberWithinADifferentTypes()
        {
            Assert.AreEqual(2,2d);
        }
        [Test]
        public void AreEqualNumberWithinTolerance()
        {
            Assert.AreEqual(2, 2.1,.5);
        }
    }
}
