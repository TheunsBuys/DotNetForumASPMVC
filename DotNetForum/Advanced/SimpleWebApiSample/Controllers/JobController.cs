using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;
using SimpleWebApiSample.Models;

namespace SimpleWebApiSample.Controllers
{
    public class JobController : ApiController
    {
        // GET: api/Job
        [ResponseType(typeof(IEnumerable<JobDto>))]
        public IHttpActionResult Get()
        {
            var jobsList = new List<JobDto>
            {
                new JobDto
                {
                    JobId = 1,
                    Description = "Software Engineer",
                    Location = "Cape Town"
                },
                new JobDto
                {
                    JobId = 2,
                    Description = "Team Lead",
                    Location = "Durban"
                }
            };
            return Ok(jobsList);
        }

        // GET: api/Job/5
        public IHttpActionResult Get(int id)
        {
            var job = new JobDto
            {
                JobId = id,
                Description = "Software Engineer",
                Location = "Cape Town"
            };

            return Ok(job);
        }

        // POST: api/Job
        public IHttpActionResult Post([FromBody] JobDto job)
        {
            return Ok();
        }

        // PUT: api/Job/5
        public IHttpActionResult Put(int id, [FromBody] JobDto job)
        {
            return Ok();
        }

        // DELETE: api/Job/5
        public IHttpActionResult Delete(int id)
        {
            return Ok();
        }
    }
}