using System;

namespace FractionWork
{
    public interface IFraction
    {
        int numerator { get; set; }
        int denominator { get; set; }

        Fraction Add(Fraction other);
        Fraction Subtract(Fraction other);
        Fraction Multiply(Fraction other);
        bool Equals(Fraction other);
        Fraction MultiplyByInteger(int integer);
        Fraction SubtractInteger(int integer);
    }
}
