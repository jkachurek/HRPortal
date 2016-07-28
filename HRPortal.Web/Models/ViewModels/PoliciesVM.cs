using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPortal.Web.Models.Data;

namespace HRPortal.Web.Models.ViewModels
{
    public class PoliciesVM
    {
        public IEnumerable<Policy> Policies { get; set; }
        public List<SelectListItem> CategoryItems { get; set; }
        public int SelectedCategoryId { get; set; }

        public PoliciesVM()
        {
            CategoryItems = new List<SelectListItem>();
            Policies = new List<Policy>();
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
            }
        }
    }
}