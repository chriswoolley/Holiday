using HolidayWeb.Models.Interface;
using Microsoft.AspNetCore.Mvc;

namespace HolidayWeb.Controllers
{
    public class SystemSettingController : Controller
    {
        private readonly ISystemSetting _SystemSetting;

        public SystemSettingController(ISystemSetting systemSettingRepository)
        {
            _SystemSetting = systemSettingRepository;
        }

        public IActionResult Details()
        {
            var systemSettings = _SystemSetting.GetAllSystemSetting();
            return View(systemSettings);
        }
    }
}