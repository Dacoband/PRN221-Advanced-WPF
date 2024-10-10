using Candidate_BussinessObjects.Models;
using Candidate_Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
    public class CandidateProfileService : ICandidateProfileService
    {
        private readonly ICandidateProfileRepo _candidateProfileRepo;
        public CandidateProfileService ()
        {
            _candidateProfileRepo = new CandidateProfileRepo();
        }

        public bool AddCandidateProfile(CandidateProfile candidateProfile)
        {
            return _candidateProfileRepo.AddCandidateProfile(candidateProfile);
        }

        public CandidateProfile GetCandidateProfile(string candidateProfileId)
        {
            return _candidateProfileRepo.GetCandidateProfile(candidateProfileId);
        }

        public List<CandidateProfile> GetCandidateProfiles()
        {
            return _candidateProfileRepo.GetCandidateProfiles();
        }

        public bool RemoveCandidateProfile(string candidateProfileId)
        {
            return _candidateProfileRepo.RemoveCandidateProfile(candidateProfileId);
        }

        public bool UpdateCandidateProfile(CandidateProfile candidateProfile)
        {
            return _candidateProfileRepo.UpdateCandidateProfile(candidateProfile);
        }
    }
}
