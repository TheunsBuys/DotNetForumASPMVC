using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using IntermediateWebApiSample.Attributes;
using IntermediateWebApiSample.Domain;
using IntermediateWebApiSample.Models;
using IntermediateWebApiSample.Persistence.Contexts;

namespace IntermediateWebApiSample.Controllers
{
    public class JobController : ApiController
    {
        private readonly JobsContext jobsContext;

        public JobController(JobsContext jobsContext)
        {
            this.jobsContext = jobsContext;
        }

        // GET: api/Job
        public IEnumerable<JobReadModel> Get()
        {
            using (var nonDependencyInjectedContext = new JobsContext())
            {
                var jobs = nonDependencyInjectedContext.Jobs.ToList().Select(job => new JobReadModel
                {
                    JobId = job.JobId,
                    Description = job.Description,
                    Location = job.Location
                });

                return jobs;
            }
        }

        // GET: api/Job/5
        public IHttpActionResult Get(int id)
        {
            var job = jobsContext.Jobs.SingleOrDefault(j => j.JobId == id);

            if (job == null)
            {
                return BadRequest();
            }

            var jobDto = new JobReadModel
            {
                JobId = job.JobId,
                Description = job.Description,
                Location = job.Location
            };

            return Ok(jobDto);
        }

        // POST: api/Job
        [ValidateModel]
        public IHttpActionResult Post([FromBody] JobWriteModel jobModel)
        {
            var job = new Job(jobModel.Description, jobModel.Location);

            jobsContext.Jobs.Add(job);

            jobsContext.SaveChanges();

            return Ok();
        }

        // PUT: api/Job/5
        [ValidateModel]
        public async Task<IHttpActionResult> Put(int id, [FromBody] JobWriteModel jobModel)
        {
            var job = await jobsContext.Jobs.FindAsync(id);

            if (job == null)
            {
                return BadRequest();
            }

            job.UpdateLocation(jobModel.Location);
            job.UpdateDescription(jobModel.Description);

            await jobsContext.SaveChangesAsync();

            return Ok();
        }

        // DELETE: api/Job/5
        public async Task<IHttpActionResult> Delete(int id)
        {
            var job = await jobsContext.Jobs.FindAsync(id);

            if (job == null)
            {
                return BadRequest();
            }

            jobsContext.Jobs.Remove(job);

            await jobsContext.SaveChangesAsync();

            return Ok();
        }
    }
}