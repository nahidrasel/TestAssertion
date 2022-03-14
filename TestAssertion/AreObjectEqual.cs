using NUnit.Framework;

namespace TestAssertion
{
    public class AreObjectEqual
    {
        [Test]
        public void AreObjEqual()
        {
            var obj1 = "name";
            var obj2= "name";

            Assert.AreSame(obj1,obj2);

            var obj3 = "Name";
            Assert.AreNotSame(obj2,obj3);
        }

    }
}
