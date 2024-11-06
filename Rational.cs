using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalProject
{
    internal class Rational
    {
        public int numerator, denominator;
        //Parametric constructor to initialize the numerator and denominator
        public Rational(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        //Default constructor setting the numerator to 0 and denominator to 1
        public Rational()
        {
            numerator = 0;
            denominator = 1;
        }
        //Method that takes a Rational object as an argument and outputs it in some reasonable format
        public void WriteRational()
        {
            Console.WriteLine($"{numerator}/{denominator}");
        }
        //Method called Negate that reverses the sign of a rational number
        public void Negate()
        {
            numerator = -numerator;
        }
        //Method called Invert that inverts the number by swapping the numerator and denominator
        public void Invert()
        {
            int temp = numerator;
            numerator = denominator;
            denominator = temp;
        }
        //Method called ToDouble that converts the rational number to a double and returns the result
        public double ToDouble()
        {
            return (double)numerator / denominator;
        }
        //Modifier named Reduce that reduces a rational number to its lowest terms
        public Rational Reduce()
        {
            int gcd = GCD(numerator, denominator);
            return new Rational(numerator / gcd, denominator / gcd);
        }
        //Method to determine the GCD of the numerator and denominator
        private int GCD(int n1, int n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                return GCD(n2, n1 % n2);
            }
        }
        //Method called Add that takes two Rational numbers and returns a new Rational object
        public Rational Add(Rational other)
        {
            int newNumerator = (this.numerator * other.denominator) + (other.numerator * this.denominator);
            int newDenominator = this.denominator * other.denominator;
            Rational result = new Rational(newNumerator, newDenominator);
            return result.Reduce();
        }
    }
}
