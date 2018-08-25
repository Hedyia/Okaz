using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okaz.PCL.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IProductSpecification ProductSpecification { get; set; }
        public int BrandId { get; set; }
        public int VendorId { get; set; }
        public int CategoryId { get; set; }
        public string ImgUrl { get; set; }
        public List<string> ProductImgs { get; set; }
        public int Price { get; set; }
        public int Rating { get; set; }
        public bool IsFavorites { get; set; }
    }
}
