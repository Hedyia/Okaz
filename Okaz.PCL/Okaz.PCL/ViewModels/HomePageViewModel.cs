using Okaz.PCL.Models;
using Okaz.PCL.Services;
using Okaz.PCL.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using Syncfusion.ListView.XForms;
using Syncfusion.DataSource.Extensions;

namespace Okaz.PCL.ViewModels
{
	public class HomePageViewModel : BindableBase
	{
        private INavigationService _navigationService;
        private ICatalogDataService _catalogDaraService;
        private string _title = "Home";
        private Command<Syncfusion.ListView.XForms.ItemTappedEventArgs> _tapCommand;

        public Command<Syncfusion.ListView.XForms.ItemTappedEventArgs> TapCommand
        {
            get { return _tapCommand; }
            protected set { _tapCommand = value; }
        }
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        private ObservableCollection<DealsOfWeek> _dealsOfWeek;
        public ObservableCollection<DealsOfWeek> DealsOfWeek
        {
            get
            {
                if (_dealsOfWeek == null)
                {
                    _dealsOfWeek = new ObservableCollection<DealsOfWeek>()
                    {
                        new DealsOfWeek
                        {
                            Id = 1,
                            ImgUrl = "https://cms.souqcdn.com/cms/boxes/img/desktop/L_1534409464_nova-3i-MB-en.jpg"
                        },
                        new DealsOfWeek
                        {
                            Id=2,
                            ImgUrl="https://static.jumia.com.eg/api/8766821/images/2609a22f299e7__smart-phones-Slider.png"
                        },
                        new DealsOfWeek
                        {
                            Id = 3,
                            ImgUrl="https://cms.souqcdn.com/cms/boxes/img/desktop/L_1534341064_Backpacks-en.jpg"
                        }
                    };
                }
                return _dealsOfWeek;
            }
            set { SetProperty(ref _dealsOfWeek, value); }
        }
        private ObservableCollection<Brand> _brands;
        private string _filter;
        private ObservableCollection<string> _filteredProducts;
        public ObservableCollection<string> FilteredProducts
        {
            get { return _filteredProducts; }
            set { SetProperty(ref _filteredProducts, value); }
        }
        public string Filter
        {
            get { return _filter; }
            set { SetProperty(ref _filter, value); Search(); }
        }

        private void Search()
        {
            if (string.IsNullOrEmpty(Filter))
            {
                var products = Products.Select(p => p.Name).ToList();
                FilteredProducts = new ObservableCollection<string>(products);
            }
            else
            {
                FilteredProducts = FilteredProducts
                    .Where(s => s.ToLower().StartsWith(Filter.ToLower()))
                    .ToObservableCollection();
            }
        }

        public ObservableCollection<Brand> Brands
        {
            get
            {
                return _catalogDaraService.GetAllBrands();
            }
            set { SetProperty(ref _brands, value); }
        }

        public ObservableCollection<Product> Products { get => _catalogDaraService.GetAllProducts(); }

        private DelegateCommand _shoppingCartCommand;
        public DelegateCommand ShoppingCartCommand =>
            _shoppingCartCommand ?? (_shoppingCartCommand = new DelegateCommand(ExecuteShoppingCartCommand));

        void ExecuteShoppingCartCommand()
        {
            _navigationService.NavigateAsync(nameof(ShoppingCartPage));
        }
        
        public HomePageViewModel(INavigationService navigationService,ICatalogDataService catalogDataService)
        {
            _catalogDaraService = catalogDataService;
            _navigationService = navigationService;
            _tapCommand = new Command<Syncfusion.ListView.XForms.ItemTappedEventArgs>(Navigation);
            var products = Products.Select(p => p.Name).ToList();
            FilteredProducts = new ObservableCollection<string>(products);

        }
        public void Navigation(Syncfusion.ListView.XForms.ItemTappedEventArgs eventArgs)
        {
            var mobileSpecification = eventArgs.ItemData as Product;
            var p = new NavigationParameters();
            p.Add("1", mobileSpecification);

            _navigationService.NavigateAsync(nameof(ProductDetailPage), p);
        }
    }
}
