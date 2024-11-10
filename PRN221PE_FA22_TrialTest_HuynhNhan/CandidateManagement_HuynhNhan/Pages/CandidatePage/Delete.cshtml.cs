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

namespace CandidateManagement_HuynhNhan.Pages.CandidatePage
{
    public class DeleteModel : PageModel
    {
        private readonly ICandidateProfileRepository _candidateProfileRepository;

        public DeleteModel(ICandidateProfileRepository candidateProfileRepository)
        {
            _candidateProfileRepository = candidateProfileRepository;
        }

        [BindProperty]
        public CandidateProfile CandidateProfile { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidateprofile = await _candidateProfileRepository.GetCandidateProfileById(id);

            if (candidateprofile == null)
            {
                return NotFound();
            }
            else
            {
                CandidateProfile = candidateprofile;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

          _candidateProfileRepository.DeleteCandidateProfile(id);
            TempData["Message"] = "Delete successfully";


            return RedirectToPage("./Index");
        }
    }
}
