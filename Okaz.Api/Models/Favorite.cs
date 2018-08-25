using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okaz.Api.Models
{
    public class Favorite
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public List<Product> FavoriteProducts { get; set; }
    }
}
