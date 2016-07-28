using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPortal.Web.Models.Data;

namespace HRPortal.Web.Models.ViewModels
{
    public class UsersVM
    {
        public User CurrentUser { get; set; }
        public List<SelectListItem> UserItems { get; set; }

        public UsersVM()
        {
            UserItems = new List<SelectListItem>();
        }

        public void SetUserItems(IEnumerable<User> users)
        {
            foreach (var user in users)
            {
                UserItems.Add(new SelectListItem
                {
                    Text = $"{user.LastName}, {user.FirstName}",
                    Value = user.UserId.ToString()
                });
            }
        }
    }
}