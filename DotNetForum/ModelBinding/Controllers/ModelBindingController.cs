using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    public class ModelBindingController : Controller
    {
        // GET: ModelBinding
        public ActionResult Index()
        {

            var applications = new ApplicationsListViewModel();
           
            #region model from db 
            var apps = new List<ApplicationSummaryViewModel>
                       {
                           new ApplicationSummaryViewModel()
                           {
                               DateApplied = DateTime.Now,
                               CandidateId = 3,
                               JobId = 5,
                               CandidateName = "John",
                               JobName = "Developer"
                           },
                           new ApplicationSummaryViewModel()
                           {
                               DateApplied = DateTime.Now,
                               CandidateId = 6,
                               JobId = 5,
                               CandidateName = "Frank",
                               JobName = "Developer"
                           },
                           new ApplicationSummaryViewModel()
                           {
                               DateApplied = DateTime.Now,
                               CandidateId = 6,
                               JobId = 7,
                               CandidateName = "Bob",
                               JobName = "Tech Lead"
                           }
                       };
            #endregion 

            applications.Applications = apps;
            return View(applications);
        }

        [HttpGet]
        public ActionResult CreateApplication()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateList()
        {
            var applications = new ApplicationsListViewModel();
            var apps = new List<ApplicationSummaryViewModel>
                       {
                           new ApplicationSummaryViewModel()
                           {
                               DateApplied = DateTime.Now,
                               CandidateId = 3,
                               JobId = 5,
                               CandidateName = "John",
                               JobName = "Developer"
                           },
                           new ApplicationSummaryViewModel()
                           {
                               DateApplied = DateTime.Now,
                               CandidateId = 6,
                               JobId = 5,
                               CandidateName = "Frank",
                               JobName = "Developer"
                           },
                           new ApplicationSummaryViewModel()
                           {
                               DateApplied = DateTime.Now,
                               CandidateId = 6,
                               JobId = 7,
                               CandidateName = "Bob",
                               JobName = "Tech Lead"
                           }
                       };

            applications.Applications = apps;
            return View(applications);
        }

        [HttpPost]
        public ActionResult CreateList(ApplicationsListViewModel formData)
        {
            var count = formData.Applications.Count;

            // do some stuff in the db 

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Create()
        {
            var application = new ApplicationViewModel();
            application.CandidateName = Request.Form["CandidateName"];
            application.JobId = int.Parse(Request.Form["JobId"]);
            application.CandidateId = int.Parse(Request.Form["CandidateId"]);

            // do some stuff in the db 

            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public ActionResult CreateWithArgs(ApplicationViewModel application)
        {
            if (ModelState.IsValid)
            {
                //do some stuff in the db
                return RedirectToAction("Index");
            }

            return View("CreateApplication");
        }


        [HttpPost]
        public ActionResult CreateWithNoArgs()
        {
            var application = new ApplicationViewModel();
            var model = TryUpdateModel(application);

            ModelState.Clear();

            if (ModelState.IsValid)
            {
                //do some stuff in the db with model
                return RedirectToAction("Index");
            }

            return View("CreateApplication");
        }




    }
}