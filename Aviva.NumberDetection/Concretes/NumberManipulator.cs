using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aviva.NumberDetection.Interfaces;

namespace Aviva.NumberDetection.Concretes
{
    public class NumberManipulator : INumberDetector, IPrintResult
    {
        private int _lowerBound;
        private int _upperBound;

        public NumberManipulator(int lowerBound, int upperBound)
        {
            if(lowerBound < 1 || upperBound > 100)throw new OutOfBoundsException("Lower or UpperBounds have been infringed!!");
            _lowerBound = lowerBound;
            _upperBound = upperBound;
        }

        public void PrintResult(int i)
        {
            if (IsPrime(i))
            {
                Console.Out.WriteLine("{0} Is Prime",i.ToString());
            }
            else if (IsComposite(i))
            {
                Console.Out.WriteLine("{0} Is Composite", i.ToString());
            }
            else
            {
                Console.Out.WriteLine(i.ToString());
            }
        }

        public bool IsComposite(int number)
        {
            return number != 1 && !IsPrime(number) && !IsEven(number);
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsDivisableBy(int number, int divisor)
        {
            if (number == 2) return true; //only prime even number.

            if (number % 2 == 0 || number == 1) return false;
            if (divisor == 1) return true;
            var mod = number % divisor;

            if (mod == 0) return false;
            ;
            return IsDivisableBy(number, divisor - 1);
        }

        public bool IsPrime(int number)
        {
            return IsDivisableBy(number, number - 1);
        }
    }
}
