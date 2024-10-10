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

namespace CandidateRazorWeb.Pages.ProfilePage
{
    public class IndexModel : PageModel
    {
        private readonly ICandidateProfileService candidateProfileService;

        public IndexModel(ICandidateProfileService candidateProfileService)
        {
            this.candidateProfileService = candidateProfileService;
        }

        public IList<CandidateProfile> CandidateProfile { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (candidateProfileService.GetCandidateProfiles != null)
            {
                CandidateProfile = candidateProfileService.GetCandidateProfiles();
            }
        }
    }
}
