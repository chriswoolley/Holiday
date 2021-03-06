﻿using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using HolidayWeb.Core;
using HolidayWeb.Models;
using HolidayWeb.Models.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace HolidayWeb.Controllers.ApiControllers
{
    [Route("api/[controller]")]
    public class SchedulerDataController : Controller
    {
        private InMemoryAppointmentsDataContext _data;
        private IAppointment _appointment;

        private readonly UserManager<HolidayUser> _userManager;
        private readonly IRuntime _runtime;

        public SchedulerDataController(IHttpContextAccessor httpContextAccessor, IMemoryCache memoryCache, IAppointment appointment,
            UserManager<HolidayUser> userManager, IRuntime _Runtime)
        {
            _data = new InMemoryAppointmentsDataContext(httpContextAccessor, appointment);
            _appointment = appointment;
            _userManager = userManager;
            _runtime = _Runtime;
        }

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_data.Appointments, loadOptions);
        }

        [HttpPost]
        public IActionResult Post(string values)
        {
            var newAppointment = new Appointment();
            JsonConvert.PopulateObject(values, newAppointment);

            if (!TryValidateModel(newAppointment))
                return BadRequest();

            if (newAppointment.StartPeriod == Period.Morning)
            {
                newAppointment.StartDate = new DateTime(newAppointment.StartDate.Year, newAppointment.StartDate.Month, newAppointment.StartDate.Day, 9, 0, 0);
            }
            else
            {
                newAppointment.StartDate = new DateTime(newAppointment.StartDate.Year, newAppointment.StartDate.Month, newAppointment.StartDate.Day, 13, 0, 0);
            }

            if (newAppointment.EndPeriod == Period.Morning)
            {
                newAppointment.EndDate = new DateTime(newAppointment.EndDate.Year, newAppointment.EndDate.Month, newAppointment.EndDate.Day, 13, 0, 0);
            }
            else
            {
                newAppointment.EndDate = new DateTime(newAppointment.EndDate.Year, newAppointment.EndDate.Month, newAppointment.EndDate.Day, 17, 0, 0);
            }

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

            _appointment.AddAppointment(newAppointment);
            _data.Appointments.Add(newAppointment);
            _data.SaveChanges();
            return Ok();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetJSONJQuery()
        {
            return Json("Test Stuff here ");
        }

        [HttpPut]
        public IActionResult Put(int key, string values)
        {
            var appointment = _data.Appointments.First(a => a.AppointmentId == key);
            JsonConvert.PopulateObject(values, appointment);
            if (!TryValidateModel(appointment))
                return BadRequest("Error");

            _data.SaveChanges();
            _appointment.EditAppointment(appointment);
            return Ok();
        }

        [HttpDelete]
        public void Delete(int key)
        {
            var appointment = _data.Appointments.First(a => a.AppointmentId == key);
            _data.Appointments.Remove(appointment);
            _data.SaveChanges();
            _appointment.DeleteAppointment(appointment);
        }
    }
}