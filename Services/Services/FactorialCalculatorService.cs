using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class FactorialCalculatorService : IFactorialCalculatorService
    {
        public string Calculate(string UserInputNumber)
        {
            double i, fact = 1, number;
            string outputAnswer;

            number = double.Parse(UserInputNumber);
            
            for (int k = 1; k <= number; k++)
            {
                outputAnswer = "{0} * " + k;
            }

            for (int j = 1; j <= number; j++)
            {
                fact = fact * j;
            }

            return  fact.ToString();
        }
    }
}
