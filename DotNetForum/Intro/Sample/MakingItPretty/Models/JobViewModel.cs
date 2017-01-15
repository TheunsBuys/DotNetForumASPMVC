using System.ComponentModel.DataAnnotations;

namespace MakingItPretty.Models
{
    public class JobViewModel
    {
        public int Jobid { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        [Display(Name = "Salary Range")]
        public string SalaryRange { get; set; }
        public string Location { get; set; }
    }

    public class JobInputModel
    {
        public int JobId { get; set; }
        public int CandidateId { get; set; }

        // show required (consider reference types and their default values)
        //[Required]
        //public int Availabilty { get; set; }

        // show binding naming error
        //public int Jobid { get; set; }
    }
}