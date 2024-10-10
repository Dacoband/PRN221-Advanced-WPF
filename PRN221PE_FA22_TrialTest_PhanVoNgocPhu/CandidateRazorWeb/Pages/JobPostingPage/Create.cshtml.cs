using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Candidate_BussinessObjects.Models;
using Candidate_Daos;
using Candidate_Services;

namespace CandidateRazorWeb.Pages.JobPostingPage
{
    public class CreateModel : PageModel
    {
        private readonly IJobPostingService _jobPostingService;

        public CreateModel(IJobPostingService jobPostingService)
        {
            this._jobPostingService = jobPostingService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public JobPosting JobPosting { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _jobPostingService.GetJobPostings() == null || JobPosting == null)
            {
                return Page();
            }

            _jobPostingService.AddJobPosting(JobPosting);

            return RedirectToPage("./Index");
        }
    }
}
