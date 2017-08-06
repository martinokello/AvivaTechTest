using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aviva.NumberDetection.Concretes;

namespace Aviva.NumberDetection
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberManipulator = new NumberManipulator(1,100);

            for (var i = 1; i < 101; i++)
            {
                numberManipulator.PrintResult(i);
            }
        }
    }
}
