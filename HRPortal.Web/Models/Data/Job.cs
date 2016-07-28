using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRPortal.Web.Models.Data
{
    public class Job
    {
        public int JobId { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public DateTime StartDate { get; set; }
        public string Description { get; set; }
        public decimal PayRate { get; set; }
    }
}