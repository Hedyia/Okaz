using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okaz.PCL.Models
{
    public class MobileSpecification : Product
    {
        public string Brand { get; set; }
        public string OS { get; set; }
        public string StorageCapacity { get; set; }
        public string NumberOfSIM { get; set; }
        public string MobilePhoneType { get; set; }
        public string CellularNetworkTechnology { get; set; }
        public string ChipsetManufacturer { get; set; }
        public string ModelNumber { get; set; }
        public string EAN13 { get; set; }
        public string BatteryCapacityInMah { get; set; }
        public string RearCameraResolution { get; set; }
        public bool Audio { get; set; }
        public string DisplaySize { get; set; }
        public bool NFC { get; set; }
        public bool FrontFlash { get; set; }
        public string Color { get; set; }
        public bool FastCharge { get; set; }
        public string OSVersion { get; set; }
        public string MemoryRAM { get; set; }
    }
}
