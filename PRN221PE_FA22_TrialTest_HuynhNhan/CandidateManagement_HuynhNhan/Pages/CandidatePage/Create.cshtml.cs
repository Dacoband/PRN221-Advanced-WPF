using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CandidateManagement_BussinessObject;
using CandidateManagement_BussinessObject.Entities;

namespace CandidateManagement_HuynhNhan.Pages.CandidatePage
{
    public class CreateModel : PageModel
    {
        private readonly CandidateManagement_BussinessObject.CandidateManagementContext _context;

        public CreateModel(CandidateManagement_BussinessObject.CandidateManagementContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PostingId"] = new SelectList(_context.JobPostings, "PostingId", "PostingId");
            return Page();
        }

        [BindProperty]
        public CandidateProfile CandidateProfile { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CandidateProfiles.Add(CandidateProfile);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
