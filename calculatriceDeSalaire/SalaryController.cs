using calculatriceDeSalaire.Services;
using Microsoft.AspNetCore.Mvc;

namespace calculatriceDeSalaire.Controllers
{
    [Route("api/[controller]")]
    public class SalaryController
    {
        private ISalaryCalculator _calculator;
        public SalaryController(ISalaryCalculator injectedCalculator)
        {
            _calculator = injectedCalculator;
        }

        [HttpGet("{yearlyAmount}")]
        public Double Get(Double yearlyAmount)
        {
            Double calculatedSalary = _calculator.CalculateSalary(yearlyAmount);
            return calculatedSalary;
        }
    }
}
