using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day4WebApiDapper.ViewModels
{
    public class ProductWithPhoto
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string LargePhotoFileName { get; set; }
    }
}
