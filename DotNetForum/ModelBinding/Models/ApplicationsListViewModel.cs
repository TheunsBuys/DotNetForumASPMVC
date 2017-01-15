using System;
using System.Collections.Generic;

namespace ModelBinding.Models
{
    public class ApplicationsListViewModel
    {
        public ApplicationsListViewModel()
        {
            Applications = new List<ApplicationSummaryViewModel>();
        }
        public IList<ApplicationSummaryViewModel> Applications { get; set; }
    }

    public class ApplicationSummaryViewModel
    {
        public int JobId { get; set; }
        public int CandidateId { get; set; }

        public string CandidateName { get; set; }
        public string JobName { get; set; }

        public DateTime DateApplied { get; set; }
    }

    public class ApplicationViewModel
    {
        public int JobId { get; set; }
        public int CandidateId { get; set; }

        public string CandidateName { get; set; }

        public DateTime StartDate { get; set; }
    }
}