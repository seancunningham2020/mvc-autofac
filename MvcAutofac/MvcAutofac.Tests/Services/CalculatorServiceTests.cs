using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcAutofac.Services;

namespace MvcAutofac.Tests.Services
{
    [TestClass]
    public class CalculatorServiceTests
    {
        [TestMethod]
        public void Calculate_GivenNumber_ReturnCorrectValue()
        {
            // Given
            var stringOfNumbers = "1234";
            var calculatorService = new CalculatorService();
            
            // When
            var result = calculatorService.Calculate(stringOfNumbers);

            // Then
            Assert.AreEqual(16, result);
        }
    }
}
