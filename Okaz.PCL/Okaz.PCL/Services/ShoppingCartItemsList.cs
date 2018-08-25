using Okaz.PCL.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okaz.PCL.Services
{
    public class ShoppingCartItemsList
    {

        public static ObservableCollection<ShoppingCartItem> ShoppingCartItems = new ObservableCollection<ShoppingCartItem>();

        public static bool PushOnStack(ShoppingCartItem item)
        {
            try
            {
                ShoppingCartItems.Add(item);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public static bool RemoveOnStack(int id)
        {
            try
            {
                var item = ShoppingCartItems.SingleOrDefault(i => i.Id == id);
                ShoppingCartItems.Remove(item);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

    }
}
