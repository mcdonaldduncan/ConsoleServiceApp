using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleServiceApp.Services
{
    internal class MathServices
    {
        /// <summary>
        /// Returns sum of a + b
        /// </summary>
        public double Sum(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Returns difference of a - b
        /// </summary>
        public double Difference(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Returns product of a * b
        /// </summary>
        public double Product(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Returns quotient of a / b
        /// </summary>
        public double Quotient(double a, double b)
        {
            return a / b;
        }

    }
}
