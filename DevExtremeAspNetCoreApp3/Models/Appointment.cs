using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using HolidayWeb.Core;
using Newtonsoft.Json;

namespace HolidayWeb.Models
{
    public class Appointment
    {
        [Key]
        [JsonProperty(PropertyName = "AppointmentId")]
        public int AppointmentId { get; set; }

        [JsonProperty(PropertyName = "Text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "StartDate")]
        public DateTime StartDate { get; set; }

        [JsonProperty(PropertyName = "EndDate")]
        public DateTime EndDate { get; set; }

        [JsonProperty(PropertyName = "AllDay")]
        public bool AllDay { get; set; }

        [JsonProperty(PropertyName = "RecurrenceRule")]
        public string RecurrenceRule { get; set; }

        [JsonProperty(PropertyName = "DepartmentID")]
        public int DepartmentID { get; set; }

        [JsonProperty(PropertyName = "StatusKey")]
        public Status StatusKey { get; set; }

        [JsonProperty(PropertyName = "UserID")]
        public string UserID { get; set; }

        [JsonProperty(PropertyName = "HolidaysTaken")]
        public int HolidaysTaken { get; set; }

        [JsonProperty(PropertyName = "Duration")]
        public int Duration { get; set; }

        [JsonProperty(PropertyName = "StartPeriod")]
        public Period StartPeriod { get; set; }

        [JsonProperty(PropertyName = "EndPeriod")]
        public Period EndPeriod { get; set; }

        //
        public bool readOnlyForUser(string userID)
        {
            return UserID == userID;
        }


        public bool disabled()
        {
            return true;
        }


        public void copyValueFrom(Appointment appointment)
        {
            this.AllDay = appointment.AllDay;
            this.DepartmentID = appointment.DepartmentID;
            this.Description = appointment.Description;
            this.Duration = appointment.Duration;
            this.EndDate = appointment.EndDate;
            this.EndPeriod = appointment.EndPeriod;
            this.HolidaysTaken = appointment.HolidaysTaken;
            this.RecurrenceRule = appointment.RecurrenceRule;
            this.StartDate = appointment.StartDate;
            this.StartPeriod = appointment.StartPeriod;
            this.StatusKey = appointment.StatusKey;
            this.Text = appointment.Text;
            this.UserID = appointment.UserID;
        }

        public void CorrectValuesFromPeriodSetting()
        {
            if (StartPeriod == Period.Morning)
            {
                StartDate = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, 9, 0, 0);
            }
            else
            {
                StartDate = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, 13, 0, 0);
            }

            if (EndPeriod == Period.Morning)
            {
                EndDate = new DateTime(EndDate.Year, EndDate.Month, EndDate.Day, 13, 0, 0);
            }
            else
            {
                EndDate = new DateTime(EndDate.Year, EndDate.Month, EndDate.Day, 17, 0, 0);
            }

        }



    }
}