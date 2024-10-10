﻿using Candidate_BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAOs
{
    public class CandidateProfileDAO
    {
        private CandidateManagementContext context;
        private static CandidateProfileDAO instance = null;
        public static CandidateProfileDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CandidateProfileDAO();
                }
                return instance;
            }
        }
        public CandidateProfileDAO()
        {
            context = new CandidateManagementContext();
        }
        public CandidateProfile GetCandidateProfile(string candiateProfileId)
        {
            return context.CandidateProfiles.SingleOrDefault(c => c.CandidateId.Equals(candiateProfileId));
        }
        public List<CandidateProfile> GetCandidateProfiles()
        {
            return context.CandidateProfiles.ToList();
        }
        public bool AddCandidateProfile(CandidateProfile candidateProfile)
        {
            bool isSuccess = false;
            try
            {
                context.CandidateProfiles.Add(candidateProfile);
                context.SaveChanges();
                isSuccess = true;
            }
            catch (Exception e)
            {
            }
            return isSuccess;
        }
        public bool RemoveCandidateProfile(string candidateProfileId)
        {
            bool isSuccess = false;
            try
            {
                CandidateProfile candidateProfile = GetCandidateProfile(candidateProfileId);
                if (candidateProfile != null)
                {
                    context.CandidateProfiles.Remove(candidateProfile);
                    context.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception e)
            {
            }
            return isSuccess;
        }
        public bool UpdateCandidateProfile(CandidateProfile candidateProfile)
        {
            bool isSuccess = false;
            try
            {
                CandidateProfile candidate = GetCandidateProfile(candidateProfile.CandidateId);
                if (candidate != null)
                {
                    //xử hàm update 
                    context.CandidateProfiles.Update(candidate);
                    context.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
            }
            return isSuccess;
        }
    }
}