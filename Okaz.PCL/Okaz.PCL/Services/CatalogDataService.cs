using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Okaz.PCL.Models;
using Xamarin.Forms;

namespace Okaz.PCL.Services
{
    public class CatalogDataService : ICatalogDataService
    {
        #region BackingFields
        private ObservableCollection<User> _users;
        private ObservableCollection<Product> _products;
        private ObservableCollection<Category> _categories;
        private ObservableCollection<Brand> _brands;
        private ObservableCollection<Vendor> _vendors;
        private ShoppingCart _shoppingCart;
        #endregion
        private ObservableCollection<MobileSpecification> _getAllPhones;

        #region Properties
        #endregion
        #region Methods
        public ObservableCollection<Brand> GetAllBrands()
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
                        },
                        new Brand
                        {
                            Id = 5,
                            ImgUrl = "http://logosvector.net/wp-content/uploads/2015/07/new-lenovo-logo.png"
                        }
                };
            }
            return _brands;
        }

        public ObservableCollection<Category> GetAllCategories()
        {
            if (_categories == null)
            {
                _categories = new ObservableCollection<Category>()
                {
                    new Category
                    {
                        Id = 1,
                        Name = "Mobile"
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "Laptop"
                    },
                    new Category
                    {
                        Id = 3,
                        Name = "Tablet"
                    }
                };
            }
            return _categories;
        }
        public ObservableCollection<Product> GetAllProducts()
        {
            if (_products == null)
            {
                _products = new ObservableCollection<Product>()
                {
                    new Product
                    {
                         Id = 1,
                        Name = "Huawei Nova 3i",
                        Description = "Huawei Nova 3i Dual SIM - 128GB, 4GB RAM, 4G LTE, Iris Purple",
                        ImgUrl = "https://cf5.s3.souqcdn.com/item/2018/07/30/36/83/16/50/item_XL_36831650_144172190.jpg",
                        ProductImgs = new List<string>()
                        {
                            "https://cf5.s3.souqcdn.com/item/2018/07/30/36/83/16/50/item_XL_36831650_144172190.jpg",
                            "https://cf4.s3.souqcdn.com/item/2018/07/30/36/83/16/50/item_XL_36831650_144172222.jpg",
                            "https://cf3.s3.souqcdn.com/item/2018/07/30/36/83/16/50/item_XL_36831650_144172289.jpg",
                            "https://cf1.s3.souqcdn.com/item/2018/07/30/36/83/16/50/item_XL_36831650_144172326.jpg"
                        },
                        Price = 5819,
                        Rating = 4,
                        IsFavorites = false,
                        BrandId = 1,
                        VendorId = 1,
                        CategoryId = 1,
                        ProductSpecification = new MobileSpecification
                        {
                            OS = "Android",
                            ProcessorType = "HiSilicon Kirin 710",
                            StorageCapacity = "128 GB",
                            NumberOfSIM = "Dual SIM",
                            MobilePhoneType = "Smartphone",
                            CellularNetworkTechnology = "4G LTE",
                            ChipsetManufacturer = "Huawei Kirin",
                            ModelNumber = "Nova 3i",
                            BatteryCapacityInMah = "3000 - 4000 mAH",
                            EAN13 = "2724645481014",
                            RearCameraResolution = "16 MP + 2 MP",
                            Audio = true,
                            DisplaySize = "6.3 Inch",
                            NFC = false,
                            Color ="Purple",
                            FastCharge = false,
                            MemoryRAM = "4GB",
                            FrontFlash = false,
                            OSVersion = "Android8.1.0"
                        }

                    },
                    new Product
                    {
                        Name = "Lenovo IdeaPad",
                        Description = "Lenovo IdeaPad 120s Laptop - Intel Celeron N3350, 14-Inch HD, 64GB, 4GB, Eng-Arb-Keyboard, Windows 10, Blue",
                        ImgUrl = "https://cf3.s3.souqcdn.com/item/2018/01/23/30/18/70/26/item_XL_30187026_93217749.jpg",
                        ProductImgs = new List<string>()
                        {
                            "https://cf3.s3.souqcdn.com/item/2018/01/23/30/18/70/26/item_XL_30187026_93217749.jpg",
                            "https://cf4.s3.souqcdn.com/item/2018/01/23/30/18/70/26/item_XL_30187026_93217759.jpg",
                            "https://cf4.s3.souqcdn.com/item/2018/01/23/30/18/70/26/item_XL_30187026_93217773.jpg"
                        },
                        Price = 4965,
                        Rating = 4,
                        IsFavorites = false,
                        BrandId = 5,
                        VendorId = 1,
                        CategoryId = 2,
                        ProductSpecification = new LaptopSpecification
                        {
                            Brand = "Lenovo",
                            Color = "Blue",
                            DisplaySize = "14 inch",
                            GraphicsCardCapacity = "Shared - Built in",
                            HardDiskCapacity = "64GB",
                            ItemEAN = "",
                            KeyboardLanguages = "Eng-Arb-Keyboard",
                            LaptopFamily = "",
                            MemoryCardReader = true,
                            MemoryTechnology = "DDR",
                            ModelNumber = "",
                            NumberOfProcessorCore = "Dual Core",
                            OpticalDriveType = "Without Optical Drive",
                            OS = "Windows",
                            ProcessorFamily = "",
                            ProcessorSpeed = "Less than 1.6 GHz",
                            ProcessorType = "Celeron N3350",
                            RamSize = "4 GB",
                            TochScreen = false,
                            Usage = "Home",
                            USB = "USB 3.0",
                            VideoControllerManufacturer = "Intel"
                        }

                    }
                };
            }
            return _products;
        }

        public ObservableCollection<Vendor> GetAllVendors()
        {
            if (_vendors == null)
            {
                _vendors = new ObservableCollection<Vendor>()
                {

                };
            }
            return _vendors;
        }
        public ShoppingCart GetShoppingCart()
        {
            if (_shoppingCart == null)
            {
                _shoppingCart = new ShoppingCart
                {
                    Id = 1,
                    UserName = GetUserName.UserName,
                    ShoppingCartItems = ShoppingCartItemsList.ShoppingCartItems
                };
            }
            return _shoppingCart;
        }
        public ObservableCollection<User> GetAllUsers()
        {
            if (_users == null)
            {
                _users = new ObservableCollection<User>()
                {
                    new User
                    {
                        Id = 1,
                        Name = "Muhammed Hedyia",
                        PhoneNumber = "01069505019",
                        Email = "hedyia@hotmail.com",
                        Password = "123@muo"

                    },
                    new User
                    {
                        Id = 2,
                        Name = "Ahmed Mustafa",
                        PhoneNumber = "01210038239",
                        Email = "muo.cpp@gmail.com",
                        Password = "123@muo"

                    },

                };
            }
            return _users;
        }


        #endregion



        public ObservableCollection<Rating> GetProductRatting()
        {
            throw new NotImplementedException();
        }
    }
}
