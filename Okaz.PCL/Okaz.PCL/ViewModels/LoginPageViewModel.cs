using Acr.UserDialogs;
using Okaz.PCL.Services;
using Okaz.PCL.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using Stormlion.SNavigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Okaz.PCL.ViewModels
{
	public class LoginPageViewModel : BindableBase
	{
        #region BackingFields
        INavigationService _navigationService;
        IPageDialogService _pageDialogService;
        ICatalogDataService _catalogDataService;
        private DelegateCommand _onLoginCommand;
        private string _title = "Login";
        private string _email = "muo.cpp@gmail.com" ;
        private string _password = "123@muo" ;
        private bool _isRemebered = false;
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
            if(String.IsNullOrEmpty(this.Email))
            {
                _pageDialogService.DisplayAlertAsync("Error", "You must enter an email.", "Accept");
                return;
            }

            if (String.IsNullOrEmpty(this.Password))
            {
                _pageDialogService.DisplayAlertAsync("Error", "You must enter a password.", "Accept");
                return;
            }
            var user = _catalogDataService.GetAllUsers().Single(u => u.Email == Email);
            if (user == null)
            {
                _pageDialogService.DisplayAlertAsync("Login Field", "The User Doesn't Exisit!", "Accept");
                return;
            }
            if (user.Password != Password)
            {
                _pageDialogService.DisplayAlertAsync("Error", "The password is incorrect", "Accept");
                Email = "";
                Password = "";
                return;
            }
            if (_isRemebered)
            {
                Application.Current.Properties["IsRemembred"] = IsRemebered;
                Application.Current.Properties["Email"] = Email;
                GetUserName.UserName = user.Name;
                Application.Current.Properties["Password"] = Password;
            }
            if (!_isRemebered)
            {
                Application.Current.Properties["IsRemembred"] = false;
                GetUserName.UserName = user.Name;
            }
            // _pageDialogService.DisplayAlertAsync("Login", "Hello World", "Accept");
            UserDialogs.Instance.ShowLoading("Loading", MaskType.Black);
            LoadingPage().ContinueWith((task) => { UserDialogs.Instance.HideLoading(); });
        }
        private async Task LoadingPage()
        {
            await _navigationService.NavigateAsync(nameof(MasterPage) + "/" + nameof(NavigationPage) + "/" + nameof(HomePage));

        }
        #endregion
        #region Constructors
        public LoginPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService,  ICatalogDataService catalogDataService)
        {
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;
            _catalogDataService = catalogDataService;
            if (_isRemebered)
            {
                ExecuteOnLoginCommand();
            }
        }
        #endregion

    }
}
