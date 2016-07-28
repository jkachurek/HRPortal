using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPortal.Web.Models.Data;

namespace HRPortal.Web.Models.ViewModels
{
    public class PolicyVM
    {
        public Policy Policy { get; set; }
        public List<SelectListItem> CategoryItems { get; set; }

        public PolicyVM()
        {
            Policy = new Policy();
            CategoryItems = new List<SelectListItem>();
        }

        public void SetCategoryItems(IEnumerable<Category> categories)
        {
            foreach (var category in categories)
            {
                CategoryItems.Add(new SelectListItem
                {
                    Text = category.Name,
                    Value = category.CategoryId.ToString()
                });
            };
        }
    }
}