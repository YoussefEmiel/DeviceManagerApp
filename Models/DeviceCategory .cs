using System.Collections.Generic;

namespace DeviceManagerApp.Models
{
    public class DeviceCategory
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Property> Properties { get; set; } // Ensure this is initialized
    }
}
