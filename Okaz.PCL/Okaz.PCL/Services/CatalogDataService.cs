using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Okaz.PCL.Models;

namespace Okaz.PCL.Services
{
    public class CatalogDataService : ICatalogDataService
    {
        private ObservableCollection<MobileSpecification> _getAllPhones;
        public ObservableCollection<MobileSpecification> GetAllPhones()
        {
            if (_getAllPhones == null)
            {
                _getAllPhones = new ObservableCollection<MobileSpecification>()
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
                        OS = "Android",
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
            
            return _getAllPhones;
        }
    }
}
