namespace Words.Core.Unit.Tests
{
    using System;
    using NUnit.Framework;
    using Words.Core;

    [TestFixture]
    public class TestShould
    {
        Test _test;
        
        [SetUp]
        public void Setup()
        {
            _test = new Test();
        }

        [Test]
        public void ConfirmOneIsNotPrime()
        {
            var result = _test.IsPrime(1);

            Assert.That(result, Is.False);
        }
    }
}