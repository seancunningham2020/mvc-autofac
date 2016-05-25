using System.Linq;
using static System.Char;

namespace MvcAutofac.Services
{
    public class CalculatorService : ICalculatorService
    {
        public int Calculate(string stringOfNumbers)
        {
            var counter = 0;
            var result = 0;

            foreach (var c in stringOfNumbers.Reverse())
            {
                if (counter%2 == 0)
                {
                    result = result + ((int)GetNumericValue(c) * 2);
                }
                else
                {
                    result = result + (int)GetNumericValue(c);
                }

                counter++;
            }

            return result;
        }
    }
}