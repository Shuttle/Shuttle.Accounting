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

            period = new Period(201815);

            Assert.That(period.Year, Is.EqualTo(2018));
            Assert.That(period.Month, Is.EqualTo(15));
        }

        [Test]
        public void Should_not_be_able_to_create_an_invalid_new_period()
        {
            Assert.That(() => new Period(0), Throws.ArgumentException);
            Assert.That(() => new Period(-1), Throws.ArgumentException);
        }
    }
}