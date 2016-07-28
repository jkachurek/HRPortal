using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPortal.Web.Models.Data;

namespace HRPortal.Web.Models.ViewModels
{
    public class TimeEntryVM
    {
        public TimeEntry TimeEntry { get; set; }
        public List<SelectListItem> EmployeeItems { get; set; }

        public TimeEntryVM()
        {
            EmployeeItems = new List<SelectListItem>();
        }

        public void SetEmployeeItems(IEnumerable<User> employees)
        {
            foreach (var e in employees)
            {
                EmployeeItems.Add(new SelectListItem
                {
                    Text = $"{e.LastName}, {e.FirstName}",
                    Value = e.UserId.ToString()
                });
            }
        }
    }
}