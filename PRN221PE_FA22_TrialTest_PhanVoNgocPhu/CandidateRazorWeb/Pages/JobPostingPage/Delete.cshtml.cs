using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Candidate_BussinessObjects.Models;
using Candidate_Daos;
using Candidate_Services;

namespace CandidateRazorWeb.Pages.JobPostingPage
{
    public class DeleteModel : PageModel
    {
        private readonly IJobPostingService _jobPostingService;

        public DeleteModel(IJobPostingService jobPostingService)
        {
            this._jobPostingService = jobPostingService;
        }

        [BindProperty]
      public JobPosting JobPosting { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _jobPostingService.GetJobPostings() == null)
            {
                return NotFound();
            }

            var jobposting = _jobPostingService.GetJobPosting(id);

            if (jobposting == null)
            {
                return NotFound();
            }
            else 
            {
                JobPosting = jobposting;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null || _jobPostingService.GetJobPostings() == null)
            {
                return NotFound();
            }
            var jobposting = _jobPostingService.GetJobPosting(id);

            if (jobposting != null)
            {
                _jobPostingService.RemoveJobPosting(id);
            }

            return RedirectToPage("./Index");
        }
    }
}
