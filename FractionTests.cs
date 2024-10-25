using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionWork.Tests
{
    [TestClass()]
    public class FractionTests
    {
        [TestMethod]
        public void Constructor_ValidFraction_ShouldCreateFraction()
        {
            int numerator = 3;
            int denominator = 4;

            Fraction fraction = new Fraction(numerator, denominator);

            Assert.AreEqual(numerator, fraction.numerator);
            Assert.AreEqual(denominator, fraction.denominator);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void SetDenominator_SetDenominatorWithZeroValue_ThrowsDivideByZeroException()
        {
            Fraction fraction = new Fraction(3, 0);
        }

        [TestMethod]
        public void AddFractions_ShouldReturnCorrectResult()
        {
            Fraction first = new Fraction(1, 2);
            Fraction second = new Fraction(1, 3);

            Fraction result = Fraction.AddFractions(first, second);

            Assert.AreEqual(5, result.numerator);
            Assert.AreEqual(6, result.denominator);
        }

        [TestMethod]
        public void SubtractionFractions_ShouldReturnCorrectResult()
        {
            Fraction first = new Fraction(3, 4);
            Fraction second = new Fraction(1, 4);

            Fraction result = Fraction.SubtractionFractions(first, second);

            Assert.AreEqual(2, result.numerator);
            Assert.AreEqual(4, result.denominator);
        }

        [TestMethod]
        public void MultiplyFractions_ShouldReturnCorrectResult()
        {
            Fraction first = new Fraction(2, 3);
            Fraction second = new Fraction(3, 4);

            Fraction result = Fraction.MultiplyFractions(first, second);

            Assert.AreEqual(6, result.numerator);
            Assert.AreEqual(12, result.denominator);
        }

        [TestMethod]
        public void EqualsFractions_EquivalentFractions_ShouldReturnTrue()
        {
            Fraction first = new Fraction(1, 2);
            Fraction second = new Fraction(2, 4);

            bool result = Fraction.EqualsFractions(first, second);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EqualsFractions_NonEquivalentFractions_ShouldReturnFalse()
        {
            Fraction first = new Fraction(1, 2);
            Fraction second = new Fraction(2, 3);

            bool result = Fraction.EqualsFractions(first, second);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void MultiplyIntegerByFraction_ShouldReturnCorrectResult()
        {
            Fraction fraction = new Fraction(2, 5);
            int multiplier = 3;

            Fraction result = Fraction.MultiplyIntegerByFraction(fraction, multiplier);

            Assert.AreEqual(6, result.numerator);
            Assert.AreEqual(5, result.denominator);
        }

        [TestMethod]
        public void SubtractionIntegerByFraction_ShouldReturnCorrectResult()
        {
            Fraction fraction = new Fraction(5, 3);
            int integer = 2;

            Fraction result = Fraction.SubtractionIntegerByFraction(fraction, integer);

            Assert.AreEqual(-1, result.numerator);
            Assert.AreEqual(3, result.denominator);
        }
    }
}
