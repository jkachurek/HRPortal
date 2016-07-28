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
    public class HRController : Controller
    {
        // GET: HR
        public ActionResult Index()
        {
            return View();
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

        [HttpGet]
        public ActionResult ViewPolicy(int id)
        {
            var policy = PolicyRepository.Get(id);
            return View(policy);
        }

        [HttpGet]
        public ActionResult ManagePolicies()
        {
            var viewModel = new PoliciesVM();
            viewModel.SetCategoryItems(CategoryRepository.GetAll());
            return View(viewModel);
        }

        [HttpGet]
        public ActionResult AddPolicy()
        {
            var viewModel = new PolicyVM();
            viewModel.SetCategoryItems(CategoryRepository.GetAll());
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult AddPolicy(PolicyVM viewModel)
        {
            if (CategoryRepository.GetAll().All(c => c.Name != viewModel.Policy.Category.Name))
            {
                viewModel.Policy.Category = CategoryRepository.Add(viewModel.Policy.Category.Name);
            }
            else viewModel.Policy.Category = CategoryRepository.Get(viewModel.Policy.Category.CategoryId);
            viewModel.Policy.PolicyId = PolicyRepository.GetNextPolicyId();
            PolicyRepository.AddPolicy(viewModel.Policy);
            return RedirectToAction("ManagePolicies");
        }

        [HttpGet]
        public ActionResult DeletePolicy(int id)
        {
            var policy = PolicyRepository.Get(id);
            return View(policy);
        }

        [HttpPost]
        public ActionResult DeletePolicy(Policy policy)
        {
            PolicyRepository.DeletePolicy(policy.PolicyId);
            return RedirectToAction("ManagePolicies");
        }

        [HttpGet]
        public ActionResult ManageCategories()
        {// TODO: Add Manage Categories View
            return View();
        }

        [HttpGet]
        public ActionResult SubmitTime()
        {
            var viewModel = new TimeEntryVM();
            viewModel.SetEmployeeItems(UserRepository.GetAll());
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult SubmitTime(TimeEntryVM viewModel)
        {
            var entry = new TimeEntry
            {
                Employee = UserRepository.Get(viewModel.TimeEntry.Employee.UserId),
                Date = viewModel.TimeEntry.Date,
                HoursWorked = viewModel.TimeEntry.HoursWorked
            };
            UserRepository.AddTimeEntry(entry);
            return RedirectToAction("ViewTimesheet", "HR");
        }

        [HttpGet]
        public ActionResult EditTime(int userId, int entryId)
        {
            var thisEmployee = UserRepository.Get(userId);
            var thisEntry = thisEmployee.TimeSheet.FirstOrDefault(x => x.EntryId == entryId);
            
            return View(thisEntry);
        }

        [HttpPost]
        public ActionResult EditTime(TimeEntry timeEntry)
        {
            timeEntry.Employee = UserRepository.Get(timeEntry.Employee.UserId);
            timeEntry.Employee.TimeSheet.RemoveAll(t => t.EntryId == timeEntry.EntryId);
            timeEntry.Employee.TimeSheet.Add(timeEntry);
            return RedirectToAction("ViewTimesheet", "HR");
        }

        [HttpGet]
        public ActionResult DeleteTime(int userId, int entryId)
        {
            var thisEmployee = UserRepository.Get(userId);
            var thisEntry = thisEmployee.TimeSheet.FirstOrDefault(x => x.EntryId == entryId);
            return View(thisEntry);
        }

        [HttpPost]
        public ActionResult DeleteTime(TimeEntry timeEntry)
        {
            timeEntry.Employee = UserRepository.Get(timeEntry.Employee.UserId);
            timeEntry.Employee.TimeSheet.RemoveAll(t => t.EntryId == timeEntry.EntryId);
            return RedirectToAction("ViewTimesheet", "HR");
        }

        [HttpGet]
        public ActionResult ViewTimesheet()
        {
            var viewModel = new UsersVM();
            viewModel.SetUserItems(UserRepository.GetAll());
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult ViewTimesheet(int id)
        {
            var viewModel = new UsersVM();
            viewModel.SetUserItems(UserRepository.GetAll());
            viewModel.CurrentUser = UserRepository.Get(id);
            viewModel.CurrentUser.SetEntryData();
            return View(viewModel);
        }
    }
}