using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_training_for_sigma
{
    public class Fraction : ICalculator,IComparable
    {
        public int Numerator { get; set; }
        private int denominator;
        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value == 0)
                {
                    value = 1;
                }
                denominator = value;
            }
        }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public object Add(object other)
        {
            Fraction b = other as Fraction;
            int nNum = this.Numerator * b.Denominator + b.Numerator * this.Denominator;//מונה החדש
            int dNum = this.Denominator * b.Denominator;//מכנה החדש
            return new Fraction(nNum, dNum);
        }
        public object Subtract(object other)
        {
            if (!(other is Fraction b))
                return null;
            int nNum = this.Numerator * b.Denominator - b.Numerator * this.Denominator;//מונה החדש
            int dNum = this.Denominator * b.Denominator;//מכנה החדש

            return new Fraction(nNum, dNum);
        }

        public int CompareTo(object? obj)
        {
              
        }
    }
}
