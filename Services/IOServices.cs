using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleServiceApp.Services
{
    internal class IOServices
    {
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

        public string FormatAppResults(double sum, double dif, double prod, double quot)
        {
            return $"Sum: {sum}\n" +
                $"Difference: {dif}\n" +
                $"Product: {prod}\n" +
                $"Quotient: {quot}";
        }
    }
}
