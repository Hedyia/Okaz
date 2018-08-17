using Okaz.PCL.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Okaz.PCL.ViewModels
{
	public class HomePageViewModel : BindableBase
	{
        private string _title = "Home";
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
        private ObservableCollection<Product> _products;
        public ObservableCollection<Product> Products
        {
            get
            {
                if (_products == null)
                {
                    _products = new ObservableCollection<Product>()
                    {
                        new Product
                        {
                            Id = 1,
                            Name = "IPhone X",
                            ImgUrl = "https://cf2.s3.souqcdn.com/item/2018/01/30/24/05/14/35/item_L_24051435_102956436.jpg",
                            Price = 18500f,
                            Ratting = 4.2f
                        },
                        new Product
                        {
                            Id = 2,
                            Name = "IPhone 8",
                            ImgUrl = "https://cf5.s3.souqcdn.com/item/2017/05/09/22/69/30/38/item_XL_22693038_31468716.jpg",
                            Price = 17777f,
                            Ratting= 4.0f
                        },
                        new Product
                        {
                            Id = 3,
                            Name = "Honor Play",
                            ImgUrl = "https://cf5.s3.souqcdn.com/item/2018/02/25/30/71/96/27/item_XL_30719627_112683537.jpg",
                            Price = 5800f,
                            Ratting = 4.5f
                        },
                        new Product
                        {
                            Id = 4,
                            Name = "mi A2",
                            ImgUrl = "https://cf2.s3.souqcdn.com/item/2018/07/04/36/31/05/78/item_XL_36310578_142775161.jpg",
                            Price = 3333f,
                            Ratting = 3.7f
                        }

                    };
                }
                return _products;
            }
            set { SetProperty(ref _products, value); }
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
        public HomePageViewModel()
        {

        }
	}
}
