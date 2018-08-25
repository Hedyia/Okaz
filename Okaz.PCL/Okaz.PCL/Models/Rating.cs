using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okaz.PCL.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }
    }
}
