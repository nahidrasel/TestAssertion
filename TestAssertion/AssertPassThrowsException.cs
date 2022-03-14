using NUnit.Framework;

namespace TestAssertion
{
    public class AssertPassThrowsException
    {
        [Test]
        public void AssertPass()
        {
            Assert.That(Assert.Pass, Throws.Exception);
        }

        [Test]
        public void ExceptionType()
        {
              Assert.That(Assert.Pass,Throws.TypeOf<AssertionException>()); 
        }
    }
}
