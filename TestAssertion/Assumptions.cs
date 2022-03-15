using NUnit.Framework;

namespace TestAssertion
{
    public class Assumptions
    {
        [Test]
        public void Assumption()
        {
            Assert.That("a value", Is.EqualTo("this value"));
        }

        [Test]
        public void AssumptionThenAsserting()
        {
            var customSettingEnabled = false;
            Assume.That(customSettingEnabled, Is.True);

            //test actions here....

            Assert.That("a value", Is.EqualTo("this value"));
        }

    }
}
