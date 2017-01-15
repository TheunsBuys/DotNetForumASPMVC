using System.ComponentModel.DataAnnotations;

namespace IntermediateWebApiSample.Models
{
    public class JobReadModel
    {
        [Required]
        public int JobId { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Location { get; set; }
    }
}