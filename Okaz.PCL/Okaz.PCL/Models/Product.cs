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
        public string ImgUrl { get; set; }
        public List<string> ProductImgs { get; set; }
        public float Price { get; set; }
        public float Rating { get; set; }
        public bool IsFavorites { get; set; }
        public int GetCountOfReviews { get; set; }
    }
}
