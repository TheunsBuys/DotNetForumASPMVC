using System.ComponentModel.DataAnnotations;

namespace IntermediateWebApiSample.Models
{
    public class JobWriteModel
    {
        [Required]
        public string Description { get; set; }

        [Required]
        public string Location { get; set; }
    }
}