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
        public ObservableCollection<Brand> Brands
        {
            get
            {
                if (_brands == null)
                {
                    _brands = new ObservableCollection<Brand>()
                    {
                        new Brand
                        {
                            Id = 1,
                            ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/29/Xiaomi_logo.svg/2000px-Xiaomi_logo.svg.png"
                        },
                        new Brand
                        {
                            Id = 2,
                            ImgUrl = "http://www.stickpng.com/assets/images/58ac4d880aaa10546adf2711.png"
                        },
                        new Brand
                        {
                            Id = 3,
                            ImgUrl = "https://image.freepik.com/free-icon/apple-logo_318-40184.jpg"
                        },
                        new Brand
                        {
                            Id = 4,
                            ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/08/Blackberry_Logo_without_wordmark.svg/2000px-Blackberry_Logo_without_wordmark.svg.png"
                        }
                    };
                }
                return _brands;
            }
            set { SetProperty(ref _brands, value); }
        }

        public ObservableCollection<MobileSpecification> Products { get => _catalogDaraService.GetAllPhones(); }
        
        public HomePageViewModel(INavigationService navigationService,ICatalogDataService catalogDataService)
        {
            _catalogDaraService = catalogDataService;
            _navigationService = navigationService;
            _tapCommand = new Command<Syncfusion.ListView.XForms.ItemTappedEventArgs>(Navigation);
        }
        public void Navigation(Syncfusion.ListView.XForms.ItemTappedEventArgs eventArgs)
        {
            var mobileSpecification = eventArgs.ItemData as MobileSpecification;
            var p = new NavigationParameters();
            p.Add("1",mobileSpecification);

            _navigationService.NavigateAsync("ProductDetailPage");
        }
    }
}
