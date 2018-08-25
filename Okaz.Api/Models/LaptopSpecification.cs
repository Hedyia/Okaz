using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okaz.Api.Models
{
    public class LaptopSpecification : IProductSepecification
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public string Brand { get; set; }
        public string ProcessorType { get; set; }
        public string USB { get; set; }
        public string DisplaySize { get; set; }
        public bool MemoryCardReader { get; set; }
        public string NumberOfProcessorCore { get; set; }
        public string VideoControllerManufacturer { get; set; }
        public string MemoryTechnology { get; set; }
        public string ProcessorSpeed { get; set; }
        public string LaptopFamily { get; set; }
        public string Usage { get; set; }
        public string OpticalDriveType { get; set; }
        public bool TochScreen { get; set; }
        public string ModelNumber { get; set; }
        public string KeyboardLanguages { get; set; }
        public string ItemEAN { get; set; }
        public string Color { get; set; }
        public string OS { get; set; }
        public string HardDiskCapacity { get; set; }
        public string RamSize { get; set; }
        public string ProcessorFamily { get; set; }
        public string GraphicsCardCapacity { get; set; }
    }
}
