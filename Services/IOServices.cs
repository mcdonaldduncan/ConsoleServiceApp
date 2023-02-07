using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleServiceApp.Services
{
    internal class IOServices
    {
        /// <summary>
        /// Get user input and parse to double, recursively fall back if parse fails
        /// </summary>
        public double GetInputToDouble()
        {
            if (double.TryParse(Console.ReadLine(), out double input))
            {
                return input;
            }
            else
            {
                return GetInputToDouble();
            }
        }

        /// <summary>
        /// Format Sum, Difference, Product and Quotient for display
        /// </summary>
        /// <param name="sum">sum result</param>
        /// <param name="difference">difference result</param>
        /// <param name="product">product result</param>
        /// <param name="quotient">quotient result</param>
        /// <returns></returns>
        public string FormatAppResults(double sum, double difference, double product, double quotient)
        {
            return $"Sum: {sum}\n" +
                $"Difference: {difference}\n" +
                $"Product: {product}\n" +
                $"Quotient: {quotient}";
        }
    }
}
