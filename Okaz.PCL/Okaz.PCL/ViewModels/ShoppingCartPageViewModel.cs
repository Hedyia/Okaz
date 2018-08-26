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
        private int _lineTotal;
        public int LineTotal
        {
            get => ShoppingCart.ShoppingCartItems.Sum(s => s.TotalLine);
            set { SetProperty(ref _lineTotal, value); }
        }
        private int _shippingCost;
        public int ShippingCost
        {
            get => 30;
            set { SetProperty(ref _shippingCost, value); }
        }
        private int _totalPrice;
        public int TotalPrice
        {
            get => ShoppingCart.ShoppingCartItems.Sum(s => s.TotalLine) + ShippingCost ;
            set { SetProperty(ref _totalPrice, value); }
        }

    }
}
