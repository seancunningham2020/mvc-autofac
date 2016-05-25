using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAutofac.Services
{
    public class CalculatorService : ICalculatorService
    {
        public int Calculate(string stringOfNumbers)
        {
            var counter = 0;
            var result = 0;

            foreach (char c in stringOfNumbers.Reverse())
            {
                if (counter%2 == 0)
                {
                    result = result + (Convert.ToInt32(c)*2);
                }
                else
                {
                    result = result + Convert.ToInt32(c);
                }

                counter++;
            }

            return result;
        }
    }
}