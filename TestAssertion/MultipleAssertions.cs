using NUnit.Framework;

namespace TestAssertion
{
    public class MultipleAssertions
    {
        [Test]
        public void WillThisMakeITThroughCodeReview()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(1, 2);
                Assert.AreEqual(2, 3);
            });
        }

        }
    }
