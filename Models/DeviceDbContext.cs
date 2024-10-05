using Microsoft.EntityFrameworkCore;

namespace DeviceManagerApp.Models
{
    public class DeviceDbContext : DbContext
    {
        public DbSet<DeviceCategory> DeviceCategories { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyValue> PropertyValues { get; set; }

        public DeviceDbContext(DbContextOptions<DeviceDbContext> options)
            : base(options)
        {
        }
    }
}
