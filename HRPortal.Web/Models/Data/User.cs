using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRPortal.Web.Models.Data
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
        public DateTime HireDate { get; set; }
        public List<TimeEntry> TimeSheet { get; set; }

        //public User()
        //{
        //    TimeSheet = new List<TimeEntry>();
        //}

        public IEnumerable<TimeEntry> GetTimeSheet()
        {
            return TimeSheet.OrderBy(t => t.Date);
        }

        public decimal GetTotalHours()
        {
            decimal totalHours = 0;
            foreach (var entry in TimeSheet)
            {
                totalHours += entry.HoursWorked;
            }
            return totalHours;
        }

        public void SetEntryData()
        {
            foreach (var entry in TimeSheet)
            {
                entry.Employee = this;
            }
        }
    }
}