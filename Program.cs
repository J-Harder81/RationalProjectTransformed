using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Main method that creates a new object with type Rational, sets its fields to some values, and writes the object
            Rational r1 = new Rational(2, 3);
            r1.WriteRational();

            Rational r2 = new Rational(3, 4);
            r2.WriteRational();

            //Test the Negate method
            Rational r3 = new Rational(4, 5);
            r3.Negate();
            r3.WriteRational();

            //Test the Invert method
            r1.Invert();
            r1.WriteRational();

            //Test the ToDouble method
            Console.WriteLine(r2.ToDouble());

            //Test the Reduced modifier
            Rational r4 = new Rational(8, 12);
            Rational reduced = r4.Reduce();
            reduced.WriteRational();

            //Test the Add method
            Rational r5 = r1.Add(r2);
            r5.WriteRational();
        }
    }
}
