using Okaz.PCL.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Okaz.PCL.ViewModels
{
	public class LoginPageViewModel : BindableBase
	{
        #region BackingFields
        INavigationService _navigationService;
        IPageDialogService _pageDialogService;
        private DelegateCommand _onLoginCommand;
        private string _title = "Login";
        private string _email = "muo.cpp@gmail.com";
        private string _password = "1234";
        private bool _isRemebered = true;
        #endregion
        #region Properties
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        public bool IsRemebered
        {
            get { return _isRemebered; }
            set { SetProperty(ref _isRemebered, value); }
        }
        #endregion
        #region Commands
        public DelegateCommand OnLoginCommand =>
            _onLoginCommand ?? (_onLoginCommand = new DelegateCommand(ExecuteOnLoginCommand));
        #endregion
        #region Methods
        void ExecuteOnLoginCommand()
        {
            // _pageDialogService.DisplayAlertAsync("Login", "Hello World", "Accept");
            _navigationService.NavigateAsync( nameof(MasterPage) + "/" + nameof(NavigationPage) + "/" + nameof(HomePage));
        }
        #endregion
        #region Constructors
        public LoginPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;
        }
        #endregion

    }
}
