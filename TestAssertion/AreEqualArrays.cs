using NUnit.Framework;
using System;

namespace TestAssertion
{
    public class AreEqualArrays
    {
            [Test]
        public void AreEqualArray()
            {
            var expected=new int [] { 1, 2, 3 };
            var actual=new int [] { 1, 3, 2 };
            Array.Sort(actual);

            // Assert.AreEqual(expected, actual);
            Assert.That(actual, Is.EqualTo(expected));

            }
        }
}
