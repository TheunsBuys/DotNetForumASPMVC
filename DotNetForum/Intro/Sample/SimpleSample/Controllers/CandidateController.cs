using SimpleSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleSample.Controllers
{
    [RoutePrefix("Candidate"), Route("{action=index}/{id?}")]
    public class CandidateController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var model = new CandidateViewModel();
            model.Candidates = new List<CandidateViewModel>()
            {
                new CandidateViewModel
                {
                    FirstName= "Koos",
                    LastName = "Venter",
                    Email = "koos@yahoo.com",
                }
            };
            return View(model);
        }

        [HttpGet]
        public ActionResult Detail(int id)
        {
            var model = new CandidateViewModel
            {
                FirstName = "Koos",
                LastName = "Venter",
                Email = "koos@yahoo.com",
            };
            return PartialView("_CandidateDetail", model);
        }

        [HttpPost]
        public ActionResult Update (CandidateViewModel candidate)
        {
            if ( candidate?.FirstName != null)
            {

            }
            return RedirectToAction(nameof(Index));
        }
    }
}