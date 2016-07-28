using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPortal.Web.Models.Data;
using HRPortal.Web.Models.Repositories;
using HRPortal.Web.Models.ViewModels;

namespace HRPortal.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Apply()
        {// Todo: Move job selection to separate menu, nest this within
            var viewModel = new ApplicationVM();
            viewModel.SetUserItems(UserRepository.GetAll());
            viewModel.SetJobItems(JobRepository.GetAll());
            return View(viewModel);
        }

        [HttpGet]
        public ActionResult ApplyDirect()
        {
            var viewModel = new ApplicationVM();
            viewModel.SetUserItems(UserRepository.GetAll());
            viewModel.SetJobItems(JobRepository.GetAll());
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Apply(JobApp application)
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Policies()
        {
            var viewModel = new PoliciesVM();
            viewModel.SetCategoryItems(CategoryRepository.GetAll());
            return View(viewModel);
        }

        [HttpGet]
        public ActionResult ViewPolicies(PoliciesVM viewModel)
        {
            viewModel.Policies = PolicyRepository.GetByCategory(viewModel.SelectedCategoryId);
            viewModel.SetCategoryItems(CategoryRepository.GetAll());
            return View(viewModel);
        }
    }
}