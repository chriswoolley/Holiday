using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using HolidayWeb.Core;
using HolidayWeb.Models;
using HolidayWeb.Models.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System;
using System.Linq;
using HolidayWeb.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace HolidayWeb.Controllers
{

    public class TagItem
    {
        public int ModelId { get; set; }
    }
    public class HomeController : Controller
    {
        //        private readonly IEvent _events;
        private readonly UserManager<HolidayUser> _userManager;

        private readonly IHolidayEntitlement _holidayEntitlement;
        private readonly IDepartment _DepartmentList;
        private readonly IState _StateList;
        private readonly IRuntime _runtime;
        private readonly IAppointment _appointmentRepository;
        private readonly MainViewModel _MainViewModel;
        private readonly SignInManager<HolidayUser> _signInManager;

        public Task<HolidayUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        public HomeController(SignInManager<HolidayUser> signInManager, IDepartment department, UserManager<HolidayUser> userManager, 
            IHolidayEntitlement _HolidayEntitlement, IState state,
            IRuntime _Runtime, IAppointment AppointmentRepository, IHolidayCalc holidayCalc)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _holidayEntitlement = _HolidayEntitlement;
            _DepartmentList = department;
            _StateList = state;
            _runtime = _Runtime;
            if (_runtime.currentDepartmentId == 0)
                _runtime.currentDepartmentId = 1;
            _appointmentRepository = AppointmentRepository;
            _MainViewModel = new MainViewModel();
            _MainViewModel.DepartmentList = _DepartmentList.GetAllDepartment();
            _MainViewModel.StateList = _StateList.GetAllState();
            _MainViewModel.DepartmentUserList = _userManager.Users.ToList();
            _MainViewModel.UserList = _userManager.Users.ToList();
            _MainViewModel.AppointmentList = _appointmentRepository.GetAllAppointment();
            holidayCalc.HolidayRemaining(_MainViewModel.DepartmentUserList, System.DateTime.Now);
        }

        public ActionResult WebAPIService()
        {
            return View();
        }

        public IActionResult TestJS()
        {
            return null;
        }

        public async Task<IActionResult> Index(int DepartmentId)
        {
            var user = await GetCurrentUserAsync();

            bool IsAdmin = (user != null) && (await _userManager.IsInRoleAsync(user, "Admin"));
            if (DepartmentId != 0)
                _runtime.currentDepartmentId = DepartmentId;
            var users = _userManager.Users;
            if (IsAdmin)
            {
                ViewBag.Users = users.Select(x => new SelectListItem { Text = x.UserName, Value = x.Id }).ToList();
                ViewBag.currentUser = user;
                ViewData["currentUserID"] = user.Id;
                if (_runtime.currentDepartmentId != 0)
                {
                    _MainViewModel.DepartmentUserList = _userManager.Users.Where(p => p.Department.Id == _runtime.currentDepartmentId);
                    _MainViewModel.UserList = _userManager.Users.Where(p => p.Department.Id == _runtime.currentDepartmentId);
                }
            }
            else
            {
                {
                    if (user != null)
                    {
                        ViewBag.Users = new SelectListItem { Text = user.UserName, Value = user.Id };
                        _MainViewModel.UserList = _userManager.Users.Where(p => p.Id == user.Id);
                        ViewData["currentUserID"] = user.Id;
                    }
                    else
                    {
                        ViewBag.Users = null;
                        // should always return empty list
                        _MainViewModel.UserList = _userManager.Users.Where(p => p.Id == "XXX");
                    }

                    _MainViewModel.DepartmentUserList = _userManager.Users.Where(p => p.Department.Id == _runtime.currentDepartmentId);
                }
            }
            return View("Index", _MainViewModel);
            //user not selecting in selection box
        }


        [HttpPost]
        public JsonResult Post([FromBody]Appointment newAppointment)
        {
            newAppointment.CorrectValuesFromPeriodSetting();
            var holidayUser = _userManager.Users.Where(p => p.Id == newAppointment.UserID).FirstOrDefault();
            if (holidayUser != null)
            {
                newAppointment.Description = holidayUser.UserName;
                if (newAppointment.StartDate.Date == newAppointment.EndDate.Date)
                {
                    if ((newAppointment.StartPeriod == Period.Morning) && (newAppointment.EndPeriod == Period.Afternoon))
                    {
                        newAppointment.Description = newAppointment.Description + " All day";
                    }
                    else
                    {
                        newAppointment.Description = newAppointment.Description + " " + newAppointment.StartPeriod.ToString();
                    }
                }
            }
            newAppointment.DepartmentID = _runtime.currentDepartmentId;
            _appointmentRepository.AddAppointment(newAppointment);
            return new JsonResult(true);
        }

        [HttpPut]
        public IActionResult Put([FromBody]Appointment newAppointment)
        {
            newAppointment.CorrectValuesFromPeriodSetting();

            var holidayUser = _userManager.Users.Where(p => p.Id == newAppointment.UserID).FirstOrDefault();
            if (holidayUser != null)
            {
                newAppointment.Description = holidayUser.UserName;
                if (newAppointment.StartDate.Date == newAppointment.EndDate.Date)
                {
                    if ((newAppointment.StartPeriod == Period.Morning) && (newAppointment.EndPeriod == Period.Afternoon))
                    {
                        newAppointment.Description = newAppointment.Description + " All day";
                    }
                    else
                    {
                        newAppointment.Description = newAppointment.Description + " " + newAppointment.StartPeriod.ToString();
                    }
                }
            }

            var appointment = _appointmentRepository.GetAppointmentById(newAppointment.AppointmentId);
            appointment.copyValueFrom(newAppointment);
            _appointmentRepository.EditAppointment(appointment);
            return Ok();
        }


        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}