using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleServiceApp.Services
{
    internal class MathServices
    {
        public double Sum(double a, double b)
        {
            return a + b;
        }

        public double Difference(double a, double b)
        {
            return a - b;
        }

        public double Product(double a, double b)
        {
            return a * b;
        }

        public double Quotient(double a, double b)
        {
            return a / b;
        }

    }
}
