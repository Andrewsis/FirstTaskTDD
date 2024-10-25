using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractionWork;

namespace FractionWork
{
    public class Fraction
    {
        public int numerator { get; set; }
        public int denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Denominator cannot be equal to 0");
            }
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static Fraction AddFractions(Fraction first, Fraction second)
        {
            int resultNumerator = first.numerator * second.denominator + second.numerator * first.denominator;
            int resultDenominator = first.denominator * second.denominator;

            return new Fraction(resultNumerator, resultDenominator);
        }

        public static Fraction SubtractionFractions(Fraction first, Fraction second)
        {
            int resultNumerator;
            int resultDenominator;
            if (first.denominator == second.denominator)
            {
                resultNumerator = first.numerator - second.numerator;
                resultDenominator = first.denominator;
                return new Fraction(resultNumerator, resultDenominator);
            }

            resultNumerator = first.numerator * second.denominator - second.numerator * first.denominator;
            resultDenominator = first.denominator * second.denominator;

            return new Fraction(resultNumerator, resultDenominator);
        }

        public static Fraction MultiplyFractions(Fraction first, Fraction second)
        {
            int resultNumerator = first.numerator * second.numerator;
            int resultDenominator = first.denominator * second.denominator;

            return new Fraction(resultNumerator, resultDenominator);
        }

        public static bool EqualsFractions(Fraction first, Fraction second)
        {
            int resultNumerator = first.numerator * second.denominator - second.numerator * first.denominator;

            if (resultNumerator == 0) return true;
            return false;
        }

        public static Fraction MultiplyIntegerByFraction(Fraction first, int second)
        {
            int resultNumerator = first.numerator * second;
            return new Fraction(resultNumerator, first.denominator);
        }

        public static Fraction SubtractionIntegerByFraction(Fraction first, int second)
        {
            int secondNumerator = second * first.denominator;
            Fraction secondFraction = new Fraction(secondNumerator, first.denominator);
            return SubtractionFractions(first, secondFraction);
        }
    }
}
