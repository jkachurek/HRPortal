using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRPortal.Web.Models.Data
{
    public class Policy
    {
        public int PolicyId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public Category Category { get; set; }
    }
}