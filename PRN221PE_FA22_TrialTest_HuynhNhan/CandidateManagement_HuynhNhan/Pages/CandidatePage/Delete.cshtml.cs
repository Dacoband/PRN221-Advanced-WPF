﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CandidateManagement_BussinessObject;
using CandidateManagement_BussinessObject.Entities;

namespace CandidateManagement_HuynhNhan.Pages.CandidatePage
{
    public class DeleteModel : PageModel
    {
        private readonly CandidateManagement_BussinessObject.CandidateManagementContext _context;

        public DeleteModel(CandidateManagement_BussinessObject.CandidateManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CandidateProfile CandidateProfile { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidateprofile = await _context.CandidateProfiles.FirstOrDefaultAsync(m => m.CandidateId == id);

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

            var candidateprofile = await _context.CandidateProfiles.FindAsync(id);
            if (candidateprofile != null)
            {
                CandidateProfile = candidateprofile;
                _context.CandidateProfiles.Remove(CandidateProfile);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}