using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapters
{
    public class ImageAdapter : IimageAdapter
    {
        public string GenerateDog()
        {
            return "https://images.dog.ceo/breeds/hound-afghan/n02088094_1406.jpg";
        }
    }
}
