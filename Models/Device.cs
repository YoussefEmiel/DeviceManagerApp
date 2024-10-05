using System;
using System.Collections.Generic;

namespace DeviceManagerApp.Models
{
    public class Device
    {
        public int ID { get; set; }
        public string DeviceName { get; set; } // Ensure this property is non-nullable
        public DeviceCategory DeviceCategory { get; set; } // Ensure this is correctly defined
        public DateTime AcquisitionDate { get; set; }
        public string Memo { get; set; }
        public ICollection<PropertyValue> PropertyValues { get; set; } // Ensure this is initialized
    }
}
