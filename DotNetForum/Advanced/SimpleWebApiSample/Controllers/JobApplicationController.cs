using System.Collections.Generic;
using System.Web.Http;
using SimpleWebApiSample.Attributes;
using SimpleWebApiSample.Models;

namespace SimpleWebApiSample.Controllers
{
    public class JobApplicationController : ApiController
    {
        // GET: api/JobApplication
        public IEnumerable<JobApplicationDto> Get()
        {
            return new List<JobApplicationDto>();
        }

        // GET: api/JobApplication/5
        public IHttpActionResult Get(int id)
        {
            var jobApplication = new JobApplicationDto
            {
                JobApplicationId = id,
                Job = new JobDto
                {
                    JobId = 1,
                    Description = "Software Engineer",
                    Location = "Cape Town"
                },
                Candidate = new CandidateDto
                {
                    CandidateId = 1,
                    FirstName = "Koos",
                    LastName = "Venter",
                    Email = "koos@yahoo.com"
                }
            };

            return Ok(jobApplication);
        }

        // POST: api/JobApplication
        public IHttpActionResult Post([FromBody] JobApplicationDto jobApplication)
        {
            if (ModelState.IsValid)
            {
                //do the things
                return Ok();
            }
            return BadRequest();
        }

        // POST: api/JobApplication/search
        [HttpPost]
        [Route("api/JobApplication/search")]
        public IHttpActionResult Search(string firstName, string lastName)
        {
            //do a search of the things
            return Ok();
        }

        // POST: api/JobApplication/processAllApplications
        [HttpPost]
        [Route("api/JobApplication/processAllApplications")]
        public IHttpActionResult ProcessAllApplications()
        {
            //do a business process with the things
            return Ok();
        }

        // PUT: api/JobApplication/5
        [ValidateModel]
        public IHttpActionResult Put(int id, [FromBody] JobApplicationDto jobApplication)
        {
            //do the things
            return Ok();
        }

        // DELETE: api/JobApplication/5
        public void Delete(int id)
        {
        }
    }
}