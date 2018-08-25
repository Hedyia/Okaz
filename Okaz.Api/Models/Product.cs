using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okaz.Api.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public string ImgUrl { get; set; }
        public List<string> ProductImgs { get; set; }
        public IProductSepecification ProductSpecification { get; set; }
        public int Price { get; set; }
        public bool InOffer { get; set; }
        public int Rating { get; set; }
    }
}
