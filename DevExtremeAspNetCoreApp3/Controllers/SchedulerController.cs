using HolidayWeb.Models.SampleData;
using Microsoft.AspNetCore.Mvc;

namespace HolidayWeb.Controllers
{
    public class SchedulerController : Controller
    {
        public ActionResult WebAPIService()
        {
            return View();
        }

        public ActionResult Editing()
        {
            return View(SampleData.Appointments);
        }
    }
}