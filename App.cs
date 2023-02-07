using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleServiceApp.Services;

namespace ConsoleServiceApp
{
    internal class App
    {
        IOServices ioServices = new IOServices();
        MathServices mathServices = new MathServices();

        public void Run()
        {
            Console.WriteLine("Please enter a number");
            double a = ioServices.GetInputToDouble();

            Console.WriteLine("Please enter another number");
            double b = ioServices.GetInputToDouble();

            string toPrint = ioServices.FormatAppResults(
                            mathServices.Sum(a, b),
                            mathServices.Difference(a, b),
                            mathServices.Product(a, b),
                            mathServices.Quotient(a, b));

            Console.WriteLine($"\n{toPrint}");

            Console.ReadKey();
        }

    }
}
