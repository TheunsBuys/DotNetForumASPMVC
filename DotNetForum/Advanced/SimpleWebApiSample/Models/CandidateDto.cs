using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebApiSample.Models
{
    public class CandidateDto
    {
        public int CandidateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
        public int YearsOfExperience { get; set; }
    }
}