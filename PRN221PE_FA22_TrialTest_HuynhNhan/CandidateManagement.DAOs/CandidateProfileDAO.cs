using CandidateManagement_BussinessObject;
using CandidateManagement_BussinessObject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement.DAOs
{
    public class CandidateProfileDAO
    {
        private readonly CandidateManagementContext _context;
        private static CandidateProfileDAO _instance;
        private CandidateProfileDAO()
        {
            _context = new CandidateManagementContext();
        }
        public static CandidateProfileDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CandidateProfileDAO();
                }
                return _instance;
            }
        }
        public async Task<List<CandidateProfile>> GetCandidateProfiles()
        {
            return await _context.CandidateProfiles.Include(x => x.Posting).ToListAsync();
        }
        public async Task<CandidateProfile> GetCandidateProfileById(int id)
        {
            return await _context.CandidateProfiles.FindAsync(id);
        }
        public async Task AddCandidateProfile(CandidateProfile candidateProfile)
        {
            _context.CandidateProfiles.Add(candidateProfile);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateCandidateProfile(CandidateProfile candidateProfile)
        {
            _context.CandidateProfiles.Update(candidateProfile);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteCandidateProfile(int id)
        {
            var candidateProfile = await _context.CandidateProfiles.FindAsync(id);
            _context.CandidateProfiles.Remove(candidateProfile);
            await _context.SaveChangesAsync();
        }   
    }
}
