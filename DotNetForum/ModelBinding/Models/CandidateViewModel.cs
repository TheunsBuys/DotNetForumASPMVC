using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModelBinding.Models
{
    public class CandidateViewModel
    {
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
        public int YearsOfExperience { get; set; }

        public IEnumerable<CandidateViewModel> Candidates { get; set; }
    }
}