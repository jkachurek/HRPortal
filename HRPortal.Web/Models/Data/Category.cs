using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRPortal.Web.Models.Data
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<Policy> Policies { get; set; }
    }
}