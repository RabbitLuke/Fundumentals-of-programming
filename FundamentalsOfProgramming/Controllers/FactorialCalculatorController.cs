using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FactorialCalculatorController : ControllerBase
    {
        private readonly IFactorialCalculatorService _factorialCalculatorService;

        public FactorialCalculatorController(IFactorialCalculatorService factorialCalculatorService)
        {
            _factorialCalculatorService = factorialCalculatorService;
        }

        [HttpGet]
        public string FactorialCalculator(string number)
        {
            var x = _factorialCalculatorService.Calculate(number);
            return x.ToString();
        }
    }
}
