using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DeviceManagerApp.Models;

namespace DeviceManagerApp.Controllers
{
    public class DeviceController : Controller
    {
        private readonly DeviceDbContext _context;

        public DeviceController(DeviceDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var devices = _context.Devices.Include(d => d.DeviceCategory).ToList();
            return View(devices);
        }
    }
}
