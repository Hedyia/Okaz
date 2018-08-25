using Okaz.PCL.Models;
using Okaz.PCL.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Okaz.PCL.ViewModels
{
	public class ProductDetailPageViewModel : BindableBase , INavigatedAware
    {
        #region BackingFields
        INavigationService _navigationService;
        private Product _productDetail;
        private ShoppingCartItem _shoppingCartItem;
        private int _qty;

        #endregion
        #region Properties
        public ShoppingCartItem ShoppingCartItem
        {
            get { return _shoppingCartItem; }
            set { SetProperty(ref _shoppingCartItem, value); }
        }
        public Product ProductDetail
        {
            get { return _productDetail; }
            set { SetProperty(ref _productDetail, value); }
        }
        public int Qty
        {
            get { return _qty; }
            set { SetProperty(ref _qty, value); }
        }

        #endregion
        #region Methods

        #endregion
        #region Constructors
        public ProductDetailPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            ProductDetail = parameters["1"] as Product;
        }
        #endregion

        private DelegateCommand _shoppingCartCommand;
        public DelegateCommand ShoppingCartCommand =>
            _shoppingCartCommand ?? (_shoppingCartCommand = new DelegateCommand(ExecuteShoppingCartCommand));

        void ExecuteShoppingCartCommand()
        {
            if (_shoppingCartItem == null)
            {
                _shoppingCartItem = new ShoppingCartItem
                {
                    Id = 1,
                    Price = ProductDetail.Price,
                    Qty = Qty,
                    Product = ProductDetail

                };
                ShoppingCartItemsList.ShoppingCartItems.Add(_shoppingCartItem);
            }
        }

    }
}
