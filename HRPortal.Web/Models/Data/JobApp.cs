using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRPortal.Web.Models.Data
{
    public class JobApp
    {
        public int AppId { get; set; }
        public User Applicant { get; set; }
        public Job Job { get; set; }
        public string Resume { get; set; }
        public string CoverLetter { get; set; }
    }
}