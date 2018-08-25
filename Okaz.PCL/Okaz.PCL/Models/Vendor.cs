using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okaz.PCL.Models
{
    public class Vendor
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public string Description { get; set; }
        public List<int> Products { get; set; }
    }
}
