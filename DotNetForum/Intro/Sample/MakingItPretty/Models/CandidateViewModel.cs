using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MakingItPretty.Models
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

        public Application LastApplication { get; set; }
    }

    public class Application
    {
        public DateTime ApplicationDate { get; set; }
        public string JobReference { get; set; }
    }

    public class CandidateAddressViewModel
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
    }
}