using System.Collections.Generic;
using System.Web.Http;
using SimpleWebApiSample.Models;

namespace SimpleWebApiSample.Controllers
{
    public class CandidateController : ApiController
    {
        // GET: api/Candidate
        public IEnumerable<CandidateDto> Get()
        {
            return new List<CandidateDto>
            {
                new CandidateDto
                {
                    CandidateId = 1,
                    FirstName = "Koos",
                    LastName = "Venter",
                    Email = "koos@yahoo.com"
                },
                new CandidateDto
                {
                    CandidateId = 2,
                    FirstName = "Bob",
                    LastName = "Dylan",
                    Email = "BtotheD@gmail.com"
                }
            };
        }

        // GET: api/Candidate/5
        public CandidateDto Get(int id)
        {
            var candidate = new CandidateDto
            {
                CandidateId = id,
                FirstName = "Koos",
                LastName = "Venter",
                Email = "koos@yahoo.com"
            };

            return candidate;
        }

        // POST: api/Candidate
        public void Post([FromBody] CandidateDto candidate)
        {
        }

        // PUT: api/Candidate/5
        public void Put(int id, [FromBody] CandidateDto candidate)
        {
        }

        // DELETE: api/Candidate/5
        public void Delete(int id)
        {
        }
    }
}