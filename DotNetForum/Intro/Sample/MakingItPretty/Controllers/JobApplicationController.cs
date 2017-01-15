using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MakingItPretty.Models;

namespace MakingItPretty.Controllers
{
    public class JobApplicationController : Controller
    {
        // GET: JobApplication
        public ActionResult Index()
        {
            return View();
        }

        // GET: JobApplication/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: JobApplication/ApplyForJob
        public ActionResult ApplyForJob(int jobId)
        { 
            // get job details from db etc etc

            var job = new JobViewModel()
                      {
                          Jobid = 1,
                          JobTitle="Software developer",
                          JobDescription= "Our client is looking to add a highly qualified graduate, with at least a Masters Degree, however our client will prefer a PhD degree\r\nDue to on-going company growth our client is now looking to recruit additional Consultants to assist customers with the implementation of new and existing programmes.\r\nThe work is varied but usually involves some form of knowledge transfer to help a customer build the first few applications and customize existing applications\r\nAll consultants work with customers on-site to install software, to build example solutions, to train customer staff (and their outside consultants if any), and to help customers build the first few applications\r\nYou will need to have had significant experience within the IT industry. Many of their existing consultants had become highly technically competent during their careers and reached management or project management roles but discovered that this was less rewarding than technical work\r\nThis opportunity is ideal for the gifted who feel frustrated or sidelined in their current career paths\r\nThe emphasis is on technical aptitude, self-motivation, inquisitiveness and experience rather than detailed knowledge in a specific field\r\nAny new hire will be fully trained in the company\'s products and acquire skill through mentoring.\r\nThe candidate will need to be based in Boston USA for a period of 1 year as internal consultant to gain experience before relocating back to South Africa as an external consultant",
                          SalaryRange="R250K-R450K",
                          Location="Johannesbug"

                      };
            return View(job);
        }

        // POST: JobApplication/ApplyForJob
        [HttpPost]
        public ActionResult ApplyForJob(JobInputModel jobInputModel)
        {
            try
            {
                System.Diagnostics.Trace.WriteLine(jobInputModel.CandidateId);
                System.Diagnostics.Trace.WriteLine(jobInputModel.JobId);
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
