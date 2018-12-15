using System;
using NUnit.Framework;

namespace Shuttle.Accounting.Tests
{
    [TestFixture]
    public class PeriodFixture
    {
        [Test]
        public void Should_be_able_to_create_a_new_period()
        {
            var period = new Period(201801);

            Assert.That(period.Year, Is.EqualTo(2018));
            Assert.That(period.Month, Is.EqualTo(1));
        }
    }
}
