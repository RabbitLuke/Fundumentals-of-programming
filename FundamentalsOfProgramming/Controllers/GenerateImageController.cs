using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class GenerateImageController : ControllerBase
    {
        private readonly IimageService _imageService;
        public GenerateImageController(IimageService imageService)
        {
           _imageService = imageService;
        }

        [HttpGet]
        public string GenerateImage()
        {
            return _imageService.GenerateDog();
        }
    }
}
