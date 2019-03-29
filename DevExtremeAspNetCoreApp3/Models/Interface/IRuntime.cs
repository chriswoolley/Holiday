using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayWeb.Models.Interface
{
    public interface IRuntime
    {      
        int currentDepartmentId { get; set; }
        string currentUserId { get; set; }
    }
}
