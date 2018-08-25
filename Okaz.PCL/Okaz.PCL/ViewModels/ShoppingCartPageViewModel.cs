using Okaz.PCL.Models;
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
        #region BackingFields
        private ObservableCollection<MobileSpecification> _shoppingCartItems;
        private MobileSpecification _shoppingCartItem;
        private INavigationService _navigationService;
        private DelegateCommand _navigationCommand;
        #endregion
        #region Properties
        private ObservableCollection<MobileSpecification> _shoppingCart;
        public ObservableCollection<MobileSpecification> ShoppingCart
        {
            get
            {
                return new ObservableCollection<MobileSpecification>()
                {
                     new MobileSpecification
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
                        Price = 5819f,
                        Rating = 4.4f,
                        IsFavorites = false,
                        GetCountOfReviews = 5,
                        Brand = "Huawei",
                        Vendor = "CompuMe",
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
                    },
                     new MobileSpecification
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
                        Price = 5819f,
                        Rating = 4.4f,
                        IsFavorites = false,
                        GetCountOfReviews = 5,
                        Brand = "Huawei",
                        Vendor = "CompuMe",
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
                    },
                     new MobileSpecification
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
                        Price = 5819f,
                        Rating = 4.4f,
                        IsFavorites = false,
                        GetCountOfReviews = 5,
                        Brand = "Huawei",
                        Vendor = "CompuMe",
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
                    },
                     new MobileSpecification
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
                        Price = 5819f,
                        Rating = 4.4f,
                        IsFavorites = false,
                        GetCountOfReviews = 5,
                        Brand = "Huawei",
                        Vendor = "CompuMe",
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
                    },
                     new MobileSpecification
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
                        Price = 5819f,
                        Rating = 4.4f,
                        IsFavorites = false,
                        GetCountOfReviews = 5,
                        Brand = "Huawei",
                        Vendor = "CompuMe",
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
                    },


                };
            }
            set { SetProperty(ref _shoppingCart, value); }
        }
        public ObservableCollection<MobileSpecification> ShoppingCartItems
        {
            get { return _shoppingCartItems; }
            set { SetProperty(ref _shoppingCartItems, value); }
        }
        public MobileSpecification ShoppingCartItem
        {
            get { return _shoppingCartItem; }
            set { SetProperty(ref _shoppingCartItem, value); }
        }
        #endregion

        #region Methods

        #endregion

        #region Constructors
        public ShoppingCartPageViewModel()
        {

        }
        #endregion
    }
}
