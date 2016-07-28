using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HRPortal.Web.Models.Data;

namespace HRPortal.Web.Models.Repositories
{
    public class ApplicationRepository
    {
        private static List<JobApp> _applications;

        static ApplicationRepository()
        {
            _applications = new List<JobApp>();
        }

        public static JobApp Get(int id)
        {
            return _applications.FirstOrDefault(a => a.AppId == id);
        }
    }
}