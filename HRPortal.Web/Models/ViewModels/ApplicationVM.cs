using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPortal.Web.Models.Data;

namespace HRPortal.Web.Models.ViewModels
{
    public class ApplicationVM
    {
        public JobApp Application { get; set; }
        public List<SelectListItem> UserItems { get; set; }
        public List<SelectListItem> JobItems { get; set; }
        

        public ApplicationVM()
        {
            UserItems = new List<SelectListItem>();
            JobItems = new List<SelectListItem>();
        }

        public void SetUserItems(IEnumerable<User> users)
        {
            foreach (var user in users)
            {
                UserItems.Add(new SelectListItem
                {
                    Text = $"{user.FirstName} {user.LastName}",
                    Value = user.UserId.ToString()
                });
            }
        }

        public void SetJobItems(IEnumerable<Job> jobs)
        {
            foreach (var job in jobs)
            {
                JobItems.Add(new SelectListItem
                {
                    Text = $"{job.Title} at {job.Company}",
                    Value = job.JobId.ToString()
                });
            }
        }
    }
}