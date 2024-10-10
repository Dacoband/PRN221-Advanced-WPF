using Candidate_BussinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
    public interface ICandidateProfileService
    {
        public bool AddCandidateProfile(CandidateProfile candidateProfile);
        public bool RemoveCandidateProfile(string candidateProfileId);
        public bool UpdateCandidateProfile(CandidateProfile candidateProfile);
        public CandidateProfile GetCandidateProfile(string candidateProfileId);
        public List<CandidateProfile> GetCandidateProfiles();
    }
}