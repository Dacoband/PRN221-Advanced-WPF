using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CandidateManagement_BussinessObject;
using CandidateManagement_BussinessObject.Entities;
using CandidateManagement.Repository.Interface;
using static System.Reflection.Metadata.BlobBuilder;

namespace CandidateManagement_HuynhNhan.Pages.CandidatePage
{
    public class IndexModel : PageModel
    {
        private readonly ICandidateProfileRepository _candidateProfileRepository;

        [BindProperty(SupportsGet = true)]
        public string SearchFullName { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchBirthday { get; set; }


        [BindProperty(SupportsGet = true)]
        public int PageNumber { get; set; } = 1;

        public int TotalPages { get; set; }

        public const int PageSize = 3;

        public IndexModel(ICandidateProfileRepository candidateProfileRepository)
        {
            _candidateProfileRepository = candidateProfileRepository;
        }

        public IList<CandidateProfile> CandidateProfile { get;set; } = default!;

        public async Task OnGetAsync()
        {
            CandidateProfile = await _candidateProfileRepository.GetCandidateProfiles();
            if (!string.IsNullOrEmpty(SearchFullName) || !string.IsNullOrEmpty(SearchBirthday))
            {
                CandidateProfile = CandidateProfile.Where(b =>
                        (string.IsNullOrEmpty(SearchFullName) || b.Fullname.Contains(SearchFullName, StringComparison.OrdinalIgnoreCase)) &&
                        (string.IsNullOrEmpty(SearchBirthday) || b.Birthday.ToString().Contains(SearchBirthday, StringComparison.OrdinalIgnoreCase)))
                .ToList();
            }

            TotalPages = (int)Math.Ceiling(CandidateProfile.Count() / (double)PageSize);
            CandidateProfile = CandidateProfile.Skip((PageNumber - 1) * PageSize).Take(PageSize).ToList();

        }
    }
}
