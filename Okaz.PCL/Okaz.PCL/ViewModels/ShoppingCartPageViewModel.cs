using Okaz.PCL.Models;
using Okaz.PCL.Services;
using Okaz.PCL.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace Okaz.PCL.ViewModels
{
	public class ShoppingCartPageViewModel : BindableBase
	{
        private ShoppingCart _shoppingCart;
        public ShoppingCart ShoppingCart
        {
            get { return _shoppingCart; }
            set { SetProperty(ref _shoppingCart, value); }
        }
        public ShoppingCartPageViewModel()
        {
            _shoppingCart = new ShoppingCart()
            {
                Id = 1,
                UserName = GetUserName.UserName,
                ShoppingCartItems = ShoppingCartItemsList.ShoppingCartItems
            };

        }
  
    }
}
