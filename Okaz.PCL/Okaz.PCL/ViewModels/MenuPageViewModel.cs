using Okaz.PCL.MenuItems;
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
	public class MenuPageViewModel : BindableBase
	{
        #region BackingFields
        private INavigationService _navigationService;
        private MenuPageItem _selectedMenuItem;
        private DelegateCommand _navigateCommand;
        #endregion
        #region Properties
        public ObservableCollection<MenuPageItem> MenuItems { get; set; }
        public MenuPageItem SelectedMenuItem
        {
            get { return _selectedMenuItem; }
            set { SetProperty(ref _selectedMenuItem, value); }
        }
        #endregion
        #region Commands
        public DelegateCommand NavigateCommand =>
           _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteNavigateCommand));
        #endregion
        #region Methods
        void ExecuteNavigateCommand()
        {
            _navigationService.NavigateAsync(nameof(MasterPage) + "../" +
                nameof(NavigationPage) + "../" +
                SelectedMenuItem.PageName);
        }
        #endregion
        #region Constructors
        public MenuPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            MenuItems = new ObservableCollection<MenuPageItem>();
            MenuItems.Add(new MenuPageItem()
            {
                PageName = nameof(HomePage),
                Icon = "ic_home",
                Title = "Home"
            });
            MenuItems.Add(new MenuPageItem()
            {
                PageName = nameof(CategoriesPage),
                Icon = "ic_category",
                Title = "Categories"
            });
            MenuItems.Add(new MenuPageItem()
            {
                PageName = nameof(OffersPage),
                Icon = "ic_local_offer",
                Title = "Offers"
            });
            MenuItems.Add(new MenuPageItem()
            {
                PageName = nameof(FavouritesPage),
                Icon = "ic_favorite",
                Title = "Favourites"
            });
            MenuItems.Add(new MenuPageItem()
            {
                PageName = nameof(ProfilePage),
                Icon = "ic_account_circle",
                Title = "Profile"
            });
            MenuItems.Add(new MenuPageItem()
            {
                PageName = nameof(LoginPage),
                Icon = "ic_exit_to_app",
                Title = "LogOut"
            });
        }
        #endregion
    }
}
