using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ImageService : IimageService
    {
        private readonly IimageAdapter _imageAdapter;

        public ImageService(IimageAdapter imageAdapter)
        {
            _imageAdapter = imageAdapter;  
        }
        public string GenerateDog()
        {
            return _imageAdapter.GenerateDog();
        }
    }
}
