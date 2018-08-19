using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okaz.PCL.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public User User { get; set; }
        public ObservableCollection<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
