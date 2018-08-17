using Okaz.PCL.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Okaz.PCL.ViewModels
{
	public class ProductDetailPageViewModel : BindableBase
	{
        #region BackingFields
        INavigationService _navigationService;
        private MobileSpecification _phoneDetail;
        #endregion
        #region Properties
        public MobileSpecification PhoneDetail
        {
            get { return _phoneDetail; }
            set { SetProperty(ref _phoneDetail, value); }
        }

        #endregion
        #region Methods

        #endregion
        #region Constructors
        public ProductDetailPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        #endregion


    }
}
