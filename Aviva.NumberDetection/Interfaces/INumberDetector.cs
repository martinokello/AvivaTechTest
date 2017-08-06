using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviva.NumberDetection.Interfaces
{
    public interface INumberDetector
    {
        bool IsPrime(int number);
        bool IsDivisableBy(int number, int divisor);
        bool IsEven(int number);
        bool IsComposite(int number);
    }
}
