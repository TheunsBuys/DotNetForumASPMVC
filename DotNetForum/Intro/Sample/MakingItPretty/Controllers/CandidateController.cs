using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MakingItPretty.Models;

namespace MakingItPretty.Controllers
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
                LastApplication = new Application()
                                  {
                                      ApplicationDate = new DateTime(2016,11,11),
                                      JobReference = "ENT001"
        
                                  }
            };
            return View( model);
        }

        [HttpGet]
        [ChildActionOnly]
        public PartialViewResult CandidateAdress(int id)
        {
            var model = new CandidateAddressViewModel
            {
                AddressLine1 = "13 Corlett Drive",
                AddressLine2 = "Melrose",
                City = "Johannesburg",
            };
            return PartialView("_CandidateAdress",model);
        }
    }
}