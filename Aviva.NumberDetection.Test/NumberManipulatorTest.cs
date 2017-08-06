using System;
using Aviva.NumberDetection.Concretes;
using Aviva.NumberDetection.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aviva.NumberDetection.Test
{
    [TestClass]
    public class NumberManipulatorTest
    {
        private const int _upperBound = 100;
        private const int _lowerBound = 1;
        private INumberDetector _numberDetector;

        [TestInitialize]
        public void SetUp()
        {
            _numberDetector = new NumberManipulator(_upperBound,_lowerBound);
        }
        [TestMethod]
        [ExpectedException(typeof(OutOfBoundsException))]
        public void TestNumber_Out_Of_Lower_Bound_Throws_Exception()
        {
            Should_Throw_Lower_Bound_Exception();
        }
        [TestMethod]
        [ExpectedException(typeof(OutOfBoundsException))]
        public void TestNumber_Out_Of_Upper_Bound_Throws_Exception()
        {
            Should_Throw_Upper_Bound_Exception();
        }
        [TestMethod]
        public void TestNumber_IsEven_10()
        {
            var number = 10;

            Assert.IsTrue(_numberDetector.IsEven(number));
        }
        [TestMethod]
        public void TestNumber_IsNotEven_9()
        {
            var number = 9;

            Assert.IsFalse(_numberDetector.IsEven(number));
        }
        [TestMethod]
        public void TestNumber_IsPrime_2()
        {
            var number = 2;

            Assert.IsTrue(_numberDetector.IsPrime(number));
        }
        [TestMethod]
        public void TestNumber_IsNotPrime_15()
        {
            var number = 15;

            Assert.IsFalse(_numberDetector.IsPrime(number));
        }
        [TestMethod]
        public void TestNumber_IsPrime_17()
        {
            var number = 17;

            Assert.IsTrue(_numberDetector.IsPrime(number));
        }
        [TestMethod]
        public void TestNumber_IsNotPrime_99()
        {
            var number = 99;

            Assert.IsFalse(_numberDetector.IsPrime(number));
        }
        [TestMethod]
        public void TestNumber_IsComposite_33()
        {
            var number = 33;

            Assert.IsTrue(_numberDetector.IsComposite(number));
        }
        [TestMethod]
        public void TestNumber_IsNotComposite_7()
        {
            var number = 7;

            Assert.IsFalse(_numberDetector.IsComposite(number));
        }

        private void Should_Throw_Lower_Bound_Exception()
        {
            _numberDetector = new NumberManipulator(0,100);
        }

        private void Should_Throw_Upper_Bound_Exception()
        {
            _numberDetector = new NumberManipulator(1, 101);
        }
    }

}
