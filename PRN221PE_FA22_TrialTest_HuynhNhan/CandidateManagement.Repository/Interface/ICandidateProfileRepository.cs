using CandidateManagement_BussinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement.Repository.Interface
{
    public interface ICandidateProfileRepository
    {
        Task<List<CandidateProfile>> GetCandidateProfiles();
        Task<CandidateProfile> GetCandidateProfileById(string id);
        Task AddCandidateProfile(CandidateProfile candidateProfile);
        Task UpdateCandidateProfile(CandidateProfile candidateProfile);
        Task DeleteCandidateProfile(string id);
    }
}
