using CandidateManagement.DAOs;
using CandidateManagement.Repository.Interface;
using CandidateManagement_BussinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement.Repository
{
    public class CandidateProfileRepository : ICandidateProfileRepository
    {
        public async Task AddCandidateProfile(CandidateProfile candidateProfile)
        {
             await CandidateProfileDAO.Instance.AddCandidateProfile(candidateProfile);
        }

        public async Task DeleteCandidateProfile(string id)
        {
            await CandidateProfileDAO.Instance.DeleteCandidateProfile(id);
        }

        public async Task<CandidateProfile> GetCandidateProfileById(string id)
        {
            return await CandidateProfileDAO.Instance.GetCandidateProfileById(id);
        }

        public async Task<List<CandidateProfile>> GetCandidateProfiles()
        {
            return await CandidateProfileDAO.Instance.GetCandidateProfiles();
        }

        public async Task UpdateCandidateProfile(CandidateProfile candidateProfile)
        {
            await CandidateProfileDAO.Instance.UpdateCandidateProfile(candidateProfile);
        }
    }
}
