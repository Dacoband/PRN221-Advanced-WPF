using Candidate_BusinessObjects.Models;
using Candidate_DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repositories
{
    public class CandidateProfileRepo : ICandidateProfileRepo
    {
        public bool AddCandidateProfile(CandidateProfile candidateProfile)
        {
            return CandidateProfileDAO.Instance.AddCandidateProfile(candidateProfile);
        }

        public CandidateProfile GetCandidateProfile(string candidateProfileId)
        {
            return CandidateProfileDAO.Instance.GetCandidateProfile(candidateProfileId);
        }

        public List<CandidateProfile> GetCandidateProfiles()
        {
            return CandidateProfileDAO.Instance.GetCandidateProfiles();
        }

        public bool RemoveCandidateProfile(string candidateProfileId)
        {
            return CandidateProfileDAO.Instance.RemoveCandidateProfile(candidateProfileId);
        }

        public bool UpdateCandidateProfile(CandidateProfile candidateProfile)
        {
            return CandidateProfileDAO.Instance.UpdateCandidateProfile(candidateProfile);
        }
    }
}
