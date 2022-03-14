using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssertion
{
    public class AdvanceOptions
    {
        [Test]
        public void UsingWarnings()
        {
            var isProcessed = false;
            Warn.Unless(isProcessed,Is.EqualTo(true).After(1).Minutes.PollEvery(10).Seconds);
            Console.WriteLine("still going");
        }
    }
}
