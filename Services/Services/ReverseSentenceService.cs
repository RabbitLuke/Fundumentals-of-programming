using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ReverseSentenceService : IReverseSentenceService
    {
        
        public string GetReverseSentence(string userInput)
        {
            string[] s = userInput.Split('-');
            string ans = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                ans += s[i] + " ";
            }
            
            return ans;
        }
    }
}
