﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CandidateManagement_BussinessObject;
using CandidateManagement_BussinessObject.Entities;

namespace CandidateManagement_HuynhNhan.Pages.CandidatePage
{
    public class EditModel : PageModel
    {
        private readonly CandidateManagement_BussinessObject.CandidateManagementContext _context;

        public EditModel(CandidateManagement_BussinessObject.CandidateManagementContext context)
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

            var candidateprofile =  await _context.CandidateProfiles.FirstOrDefaultAsync(m => m.CandidateId == id);
            if (candidateprofile == null)
            {
                return NotFound();
            }
            CandidateProfile = candidateprofile;
           ViewData["PostingId"] = new SelectList(_context.JobPostings, "PostingId", "PostingId");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CandidateProfile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CandidateProfileExists(CandidateProfile.CandidateId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CandidateProfileExists(string id)
        {
            return _context.CandidateProfiles.Any(e => e.CandidateId == id);
        }
    }
}