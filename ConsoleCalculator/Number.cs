using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Number : INumber
    {
        public double Fnumber { get; set; }
        public double Snumber { get; set; }

        public double Adding()
        {
            return Fnumber + Snumber;
        }
        public double Subtract()
        {
            return Fnumber - Snumber;
        }
        public double Multiply()
        {
            return Fnumber * Snumber;
        }
        public double Divide()
        {
            return Fnumber / Snumber;
        }
    }

}
