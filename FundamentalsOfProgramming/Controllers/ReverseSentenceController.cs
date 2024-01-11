using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReverseSentenceController : ControllerBase
    {
        private readonly IReverseSentenceService _reverseSentenceService;

        public ReverseSentenceController(IReverseSentenceService reverseSentenceService)
        {
            _reverseSentenceService = reverseSentenceService;
        }

        [HttpGet]
        public string PostAString(string sentence)
        {
            var x = _reverseSentenceService.GetReverseSentence(sentence);
            return x;
        }
    }
}
