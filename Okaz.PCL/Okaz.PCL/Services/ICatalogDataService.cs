using Okaz.PCL.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okaz.PCL.Services
{
    public interface ICatalogDataService
    {
        ObservableCollection<User> GetAllUsers();
        ObservableCollection<Product> GetAllProducts();
        ObservableCollection<Category> GetAllCategories();
        ObservableCollection<Brand> GetAllBrands();
        ObservableCollection<Vendor> GetAllVendors();
        ObservableCollection<Rating> GetProductRatting();
        ShoppingCart GetShoppingCart();

    }
}
