using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRPortal.Web.Models.Data
{
    public class TimeEntry
    {
        public int EntryId { get; set; }
        public User Employee { get; set; }
        public DateTime Date { get; set; }
        public decimal HoursWorked { get; set; }
    }
}