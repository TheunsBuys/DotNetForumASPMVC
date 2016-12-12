using System.ComponentModel.DataAnnotations;

namespace SimpleWebApiSample.Models
{
    public class JobApplicationDto
    {
        public int JobApplicationId { get; set; }

        [Required]
        public JobDto Job { get; set; }

        [Required]
        public CandidateDto Candidate { get; set; }
    }
}