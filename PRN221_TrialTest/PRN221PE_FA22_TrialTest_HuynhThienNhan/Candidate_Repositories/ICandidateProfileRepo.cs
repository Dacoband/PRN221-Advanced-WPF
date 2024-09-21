using Candidate_BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repositories
{
    public interface ICandidateProfileRepo
    {
        public bool AddCandidateProfile(CandidateProfile candidateProfile);
        public CandidateProfile GetCandidateProfile(string candidateProfileId);
        public List<CandidateProfile> GetCandidateProfiles();
        public bool RemoveCandidateProfile(string candidateProfileId);
        public bool UpdateCandidateProfile(CandidateProfile candidateProfile);

    }
}
