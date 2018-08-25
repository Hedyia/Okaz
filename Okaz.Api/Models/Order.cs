using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okaz.Api.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Total { get; set; }
        public List<Product> Products { get; set; }
        public string UserId { get; set; }
    }
}
